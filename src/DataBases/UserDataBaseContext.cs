namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class UserDataBaseContext
    {
        public IEnumerable<User> users;

        public UserDataBaseContext()
        {

            users = [
                new User("1","Jon Jones","User","JonJones@gmail.com","1234"),
                new User("2","Stepe Miocic","User","StepeMiocic@gmail.com","1234"),
                new User("3","Max Holloway","User","MaxHolloway@gmail.com","1234"),
                new User("4","Dana White","Admin","DanaWhite@gmail.com","1234")
            ];
        }


    }
}