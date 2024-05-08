namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Exceptions
{
    public class CustomErrorException : Exception
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public CustomErrorException(int status, string message)
        {
            StatusCode = status;
            Message = message;
        }

        static public CustomErrorException NotFound(string message)
        {
            return new CustomErrorException(404, message);
        }
        static public CustomErrorException UserAlreadyExists(string message)
        {
            return new CustomErrorException(409, message);
        }
        static public CustomErrorException WrongCredentials(string message)
        {
            return new CustomErrorException(401, message);
        }


    }
}