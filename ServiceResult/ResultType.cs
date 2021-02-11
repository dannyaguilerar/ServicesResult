namespace ServiceResult
{
    public enum ResultType
    {
        // Success results
        Success = 200,
        NoContent = 202,
        PartialContent = 206,

        // Caller side errors
        Invalid = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        NotAllowed = 405,
        NotAcceptable = 406,
        Conflict = 409,
        
        // Service side erros
        Error = 500,
        NotImplemented = 501

    }
}
