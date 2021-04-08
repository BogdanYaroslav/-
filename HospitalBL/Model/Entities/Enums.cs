namespace HospitalBL.Model.Entities
{
    public enum Genders
    {
        Мужской,
        Женский
    }

    public enum UserRole
    {
        Менеджер = 1,
        Врач = 2,
        Регистратор = 3
    }

    public enum UserPriority
    {
        Отсутсвует = 0,
        Низкий = 1,
        Средний = 2,
        Высокий = 3
    }

    public enum TimeBasedFilteringType
    {
        День = 0,
        Месяц = 1,
        Год = 2
    }
}
