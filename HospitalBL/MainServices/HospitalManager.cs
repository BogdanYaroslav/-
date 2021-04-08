using HospitalBL.MainServices.Interfaces;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Person;
using HospitalBL.Model.Repositories;
using HospitalBL.Model.Services;
using HospitalBL.Model.Services.Interfaces;
using HospitalBL.Properties;
using NLog;
using System;
using System.Linq;

namespace HospitalBL.MainServices
{
    public class HospitalManager
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static ISerialization SerializationService;
        
        private static Employee CurrentUser;
        private static Employee MainManager;
        
        private static HospitalManager instance;


        public IEmployeeService EmployeeService { get; set; }
        public IDiagnosisService DiagnosisService { get; set; }
        public ITreatmentService TreatmentService { get; set; }
        public IPatientService PatientService { get; set; }
        public IDiseaseService DiseaseService { get; set; }
        public IVisitService VisitService { get; set; }

        private HospitalManager()
        {
            logger.Debug("Начинается инициализация управляющего блока.");

            if (SerializationService is null) SerializationService = new JsonSerializationService();
            EmployeeService = new EmployeeService(new EmployeeRepository(SerializationService));
            DiagnosisService = new DiagnosisService(new DiagnosisRepository(SerializationService));
            TreatmentService = new TreatmentService(new TreatmentRepository(SerializationService));
            DiseaseService = new DiseaseService(new DiseaseRepository(SerializationService));
            PatientService = new PatientService(new PatientRepository(SerializationService));
            VisitService = new VisitService(new VisitRepository(SerializationService));
            logger.Debug("Инициализация управляющего блока выполнена.");
        }

        public static HospitalManager GetInstance()
        {
            if (instance is null)
            {
                instance = new HospitalManager();
                logger.Debug("Инициализация главного менеджера...");
                InitializeMainManagers();
                logger.Debug("Менеджер инициализирован");
            }            
            return instance;
        }

        public static void Save()
        {
            logger.Debug("Сохранение данных...");
            instance.EmployeeService.Save();
            instance.DiagnosisService.Save();
            instance.TreatmentService.Save();
            instance.PatientService.Save();
            instance.DiseaseService.Save();
            instance.VisitService.Save();
            logger.Debug("Данные сохранены");
        }

        public static void Load()
        {
            logger.Debug("Загрузка данных в управляющий блок...");
            instance.EmployeeService.Load();
            instance.DiagnosisService.Load();
            instance.TreatmentService.Load();
            instance.PatientService.Load();
            instance.DiseaseService.Load();
            instance.VisitService.Load();
            logger.Debug("Загрузка завершена.");
        }

        #region CurrentUser
        public static Employee GetCurrentEmployee()
        {
            return CurrentUser;
        }
        public static string GetStatusCurrentEmployee()
        {
            return $"Вы вошли в систему как {CurrentUser.FullName}. Тип пользователя {CurrentUser.Role} Уровень доступа {CurrentUser.Profile.Priority}";
        }

        public static UserRole GetRoleCurrentEmployee()
        {
            return CurrentUser.Role;
        }
        public static UserPriority GetPriorityCurrentUser()
        {
            return CurrentUser.Profile.Priority;
        }

        public static bool CurrentEmployeeIsNull()
        {
            return CurrentUser is null;
        }

        public static bool CurrentUserIsMainManager()
        {
            return CurrentUser.Equals(MainManager);
        }

        public static bool IsMainManager(Employee employee)
        {
            if (!MainManagerIsNull() && !(employee is null))
                return MainManager.Id == employee.Id;
            else return false;
        }

        #endregion

        #region MainManager
        public static string[] GetMainManagerLoginData()
        {
            return new string[] { MainManager.Profile.Login, MainManager.Profile.Password, MainManager.Role.ToString()};
        }
        private static void InitializeMainManagers()
        {
            MainManager = FindMainManager();
            if (MainManagerIsNull())
            {
                instance.EmployeeService.AddElement(new Employee(HospitalSetting.Default.defaultLoginAndpassword, HospitalSetting.Default.defaultLoginAndpassword, UserRole.Менеджер, HospitalSetting.Default.defaultName, HospitalSetting.Default.defaultName, Genders.Мужской, HospitalSetting.Default.defaultNumber, DateTime.Today.AddYears(-19), UserPriority.Высокий));
                Save();
                MainManager = FindMainManager();
            }
        }       
        
        private static Employee FindMainManager()
        {
            return instance.EmployeeService.GetElement().SingleOrDefault(m => m.Profile.Priority == UserPriority.Высокий);
        }

        public static Employee GetMainManager()
        {
            return MainManager;
        }

        public static bool MainManagerIsNull()
        {
            return MainManager is null;
        }
        #endregion

        public static bool Login(string login, string password, UserRole role)
        {
            logger.Info("Попытка авторизации пользователя");
            CurrentUser = new AuthorizationService(instance.EmployeeService).Login(login, password, role);
            if (!(CurrentUser is null))
            {
                logger.Info($"Пользователь {CurrentUser.FullName} успешно авторизовался с правами {CurrentUser.Role}");
                return true;
            }
            else
            {
                logger.Error("Логин и/или пароль неверен");
                throw new ArgumentException("Логин и/или пароль неверен");
            }
        }

        public static void Logout()
        {
            logger.Info($"Пользователь {CurrentUser.FullName} с правами {CurrentUser.Role} вышел из системы");
            Save();
            CurrentUser = default;
        }

    }
}
