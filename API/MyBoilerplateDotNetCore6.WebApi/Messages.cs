namespace MyBoilerplateDotNetCore6.WebApi
{
    public static class Messages
    {

        public static string GenericMessage_InternalServerError = "An error occured.";
        public static string GenericMessage_InvalidId = "Unable to perform action due to invalid id.";
        public static string GenericMessage_ObjectNotFoundById(string objectName, int id)
        {
            return $"Failed to fetch {objectName} by {id}";
        }

    }
}
