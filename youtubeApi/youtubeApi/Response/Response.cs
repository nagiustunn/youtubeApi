using System.Dynamic;

namespace youtubeApi.Response
{
    public class Response<T>
    {
        public Status Status { get; set; }

        public T Data { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class Response
    {
        public static Response<T> CreateSuccess<T>(T data)
        {
            return new Response<T> { Status = Status.Success, Data = data };
        }

        public static Response<T> CreateError<T>(string message)
        {
            return new Response<T> { Status = Status.Error, ErrorMessage = message };
        }
    }
}
