namespace Banking.UI
{
    public class checkUser
    {

        /// <summary>
        /// get - получает значения свойства;
        /// set - устанавливает значение свойства;
        /// IsAdmin - логическая переменная;
        /// Status - елси true(1), то это Admin, если false(0), то это User;
        /// В checkUser передается строка с логином и логической переменной;
        /// </summary>

        public string Login { get; set; }
        public bool IsAdmin { get; }

        public string Status => IsAdmin ? "Admin" : "User";

        public checkUser(string loginUser, bool isAdmin)
        {
            Login = loginUser;
            IsAdmin = isAdmin;
        }
    }
}
