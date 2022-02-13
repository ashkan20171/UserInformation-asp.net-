using System;

namespace UserInformation.Generic
{
    public class CreateUniqCode
    {
        public static string buildCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}