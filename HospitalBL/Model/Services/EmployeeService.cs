using HospitalBL.MainServices;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Person;
using HospitalBL.Model.Repositories;
using HospitalBL.Model.Services.Interfaces;
using NLog;
using System;
using System.Linq;

namespace HospitalBL.Model.Services
{   
    class EmployeeService : Service<Employee>, IEmployeeService
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public override bool SupportEditing => true;
        public override bool SupportValidation => true;
        public EmployeeService(IRepository<Employee> repository) : base(repository)
        { }

        public override void AddElement(Employee employee)
        {
            logger.Info($"Выполняется добаление работника {employee}...");
            if (HospitalManager.MainManagerIsNull())
            {
                logger.Info("Выполняется добавление главного менеджера...");
                if (employee.Role == UserRole.Менеджер && employee.Profile.Priority == UserPriority.Высокий)
                {
                    ValidateElement(employee);
                    employee.Id = ++NextId;
                    employee.Profile.Id = employee.Id;

                    base.AddElement(employee);
                    logger.Info($"Главный менеджер добавлен {employee}");
                }
                else throw new ArgumentException("Вы пытаетесь добавить главного менеджера с несоответсвующими параметрами");
            }
            else
            {
                if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Менеджер)
                    throw new Exception("Добавлять новых сотрудников может только менеджер");

                ValidateElement(employee);
                employee.Id = ++NextId;
                employee.Profile.Id = employee.Id;

                base.AddElement(employee);
                logger.Info($"Работник {employee} добавлен");
            }
        }

        public override void RemoveElement(int id)
        {
            logger.Info($"Выполняется удаления работника...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Менеджер)
                throw new Exception("Удалять пользователей может только менеджер");

            Employee employee = FindById(id);
            if (employee is null) throw new ArgumentException("Выбранного пользователя нет в базе");

            if (employee.Role == UserRole.Менеджер)
            {
                logger.Info($"Попытка удаления менеджера {employee}...");
                if (employee.Profile.Priority == UserPriority.Высокий) throw new Exception("Нельзя удалить главного менеджера");
                if (HospitalManager.GetPriorityCurrentUser() <= employee.Profile.Priority) throw new Exception("Уровень вашего доступа недостаточен для удаления выбранного пользователя");
            }
            base.RemoveElement(id);
            logger.Info($"Работник удален");
        }

        public override void EditElement(int id, Employee newEmployee)
        {
            logger.Info($"Выполняется редактирование работника...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Менеджер)
                throw new FieldAccessException("Редактировать пользователей может только менеджер");

            Employee employee = FindById(id);
            if (employee is null) throw new ArgumentNullException("Выбранного пользователя нет в базе");

            if (HospitalManager.GetPriorityCurrentUser() < employee.Profile.Priority)
                throw new FieldAccessException("Уровень вашего доступа недостаточен для удаления выбранного пользователя");

            newEmployee.Id = id;
            ValidateElement(newEmployee);           
            logger.Info($"Редактирование работника {employee}...");
            employee.Edit(newEmployee);
            logger.Info("Редактирование завершено");
            Save();
        }

        public virtual Tuple<bool,bool> AccessViewAndEditProfile(Employee employee)
        {
            logger.Info($"Вычисление уровня доступа к профилю работника {employee}...");
            Tuple<bool, bool> res = Tuple.Create(false, false);
            Employee currentEmployee = HospitalManager.GetCurrentEmployee();

            if (currentEmployee.Equals(employee))
            {
                if (HospitalManager.IsMainManager(employee)) res = Tuple.Create(true, true);
                else res = Tuple.Create(true, false);
            }
            else
            {
                if (currentEmployee.Role == UserRole.Регистратор || currentEmployee.Role == UserRole.Врач) res = Tuple.Create(false, false);
                if (currentEmployee.Role == UserRole.Менеджер)
                {
                    if (currentEmployee.Profile.Priority < employee.Profile.Priority) res = Tuple.Create(false, false);
                    else if (currentEmployee.Profile.Priority == employee.Profile.Priority) res = Tuple.Create(true, false);
                    else if (currentEmployee.Profile.Priority > employee.Profile.Priority) res = Tuple.Create(true, true);
                }
            }
            logger.Info($"Уровень доступа к профилю работника {employee} вычислен");
            return res;
        }

        public override void ValidateElement(Employee employee)
        {
            logger.Info($"Выполняется валидация данных работника {employee}...");
            if (employee is null) throw new ArgumentException("Работник не создан");
            if (string.IsNullOrWhiteSpace(employee.Name)) throw new ArgumentException("Имя не может быть пустым");
            if (string.IsNullOrWhiteSpace(employee.Surname)) throw new ArgumentException("Фамилия не может быть пустой");
            if (string.IsNullOrWhiteSpace(employee.Phone)) throw new ArgumentException("Обязательно должен быть номер телефона");


            if (employee.Name.Length < 2 || employee.Name.Length > 100 || !employee.Name.All(c => char.IsLetter(c))) throw new ArgumentException("Имя должно быть от 2 до 100 символов и содержать только буквы");
            if (employee.Surname.Length < 3 || employee.Surname.Length > 100 || !employee.Surname.All(c => char.IsLetter(c))) throw new ArgumentException("Фамилия должно быть от 2 до 100 символов и содержать только буквы");
            if (employee.Phone.Length != 12 || !employee.Phone.All(c => char.IsDigit(c))) throw new ArgumentException("Номер должен содержать 12 цифр");
            if (employee.Age < 18 || employee.Age > 70) throw new ArgumentException("Неподходящий возраст (18-70)");

            if (employee.Profile.Login.Length < 4 || !employee.Profile.Login.All(c => char.IsLetterOrDigit(c))) throw new ArgumentException("Логин должен быть не менее 4 символов и содержать только цифры и буквы");
            if (employee.Profile.Password.Length < 5 || !employee.Profile.Password.Any(c => char.IsDigit(c))) throw new ArgumentException("Пароль должен быть не менее 5 символов и содержать хотя бы одну цифру");

            Employee employeeInBase = GetElement().OriginalList.SingleOrDefault(e => e.FullName.Equals(employee.FullName) && e.Phone.Equals(employee.Phone));
            if (!(employeeInBase is null)) throw new ArgumentException("Такой работник уже есть");
            employeeInBase = GetElement().OriginalList.SingleOrDefault(e => e.Profile.Login.Equals(employee.Profile.Login) && e.Profile.Password.Equals(employee.Profile.Password) && e.Role == employee.Role);
            if (!(employeeInBase is null)) throw new ArgumentException("Логин и/или пароль заняты другим работником данной группы");

            if (!HospitalManager.MainManagerIsNull() && !HospitalManager.IsMainManager(employee))
            {
                if (employee.Role==UserRole.Регистратор || employee.Role == UserRole.Врач)
                {
                    if (employee.Profile.Priority != UserPriority.Отсутсвует)
                        throw new ArgumentException("У врача или регистратора не может быть приоритера");
                }
                else if (employee.Role == UserRole.Менеджер)
                {
                    if (employee.Profile.Priority == UserPriority.Отсутсвует || employee.Profile.Priority == UserPriority.Высокий)
                        throw new ArgumentException("У менеджера должен быть приоритет. Но высокий приоритет может быть только у одного менежера, создаваемого при первом запуске");
                }
                else throw new ArgumentException("Неизвестная роль");
            }
            else
            {
                if (employee.Role != UserRole.Менеджер) throw new ArgumentException("Главному менеджеру нельзя сменить роль");
                if(employee.Profile.Priority != UserPriority.Высокий) throw new ArgumentException("Главному менеджеру нельзя сменить приоритет");
            }
            logger.Info("Валидация завершена");
        }

        public string FilterByRole(UserRole userRole, bool setFilter=false)
        {
            string filter = string.Empty;
            filter= $"[Role] = '{userRole}'";
            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByName(string name, bool setFilter = false)
        {
            string filter = string.Empty;
            BindingListView<Employee> list = new BindingListView<Employee>(GetElement().OriginalList);

            filter = $"[FullName] = '{name}'";
            list.Filter = filter;

            if (list.Count == 0) filter = $"[Name] = '{name}'";            
            list.Filter = filter;
            if (list.Count == 0) filter = $"[Surname] = '{name}'";

            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByName(UserRole userRole, string name, bool setFilter = false)
        {
            string filter = string.Empty;

            filter = FilterByName(name);

            if (filter.Equals(string.Empty)) filter = FilterByRole(userRole);
            else filter += $" AND {FilterByRole(userRole)}";

            if (setFilter) SetFilter(filter);

            return filter;
        }
    }
}
