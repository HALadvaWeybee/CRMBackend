namespace CRMBackend.Response
{
    public class AuthResponse
    {
        public bool Success { get; set; }
        public object? Data { get; set; }
        public string? Message { get; set; }
        public error error { get; set; }
    }
    public class error
    {
        public long errorCode { get; set; }
        public string errorMessage { get; set; }
    }
}
