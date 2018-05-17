namespace ZeMShoppingCart.ViewModel.Validator
{
    public static class ValidationErrorMessage
    {
        #region Common Errors
        public const string ZeroPageSize = "PageSize should not be 0.";
        public const string SomeParametersIncorrect = "Some of the parameters have incorrect values";
        public const string RequestEntityOperatorError = "RequestEntity is null or OperatingUserId is 0.";
        public const string ApplicationIdError = "Application Id is 0.";
        public const string NoDataFound = "No data found for provided request information.";
        public const string OperatingUserFullName = "Full name of the operating user must be provided.";
        public const string InvalidLanguage = "Please provide AR for arabic and EN for english";
        #endregion

        public struct MemberErrors
        {
            public const string MemberNameLength = "Member Name should be between 0 to 100.";
            public const string MemberName = "Member Name should not be empty.";
            public const string RequestedLanguage = "RequestedLanguage should be either en or ar.";
        }
        public struct UsersErrors
        {
            public const string UserNameLength = "User Name should be between 0 to 100.";
            public const string UserName = "User Name should not be empty.";
            public const string PasswordLength = "Password should be between 0 to 100.";
            public const string Password = "Password should not be empty.";
        }
        public struct ProjectErrors
        {
            public const string ProjectZero = "ProjectId should not be 0.";
            public const string SearchMethodEmpty = "Search Method should not be emtpy.";
            public const string InvalidSearchMethod = "Only PROJNUMBER, LANDNUMBER, PROJNAME keyword allowed for search method.";
            public const string SearchCriteriaEmtpy = "Search Criteria Should not be emtpy.";
            public const string LandNumberEmpty = "Land Number Should not be emtpy.";

        }

        public struct PropertyErrors
        {
            public const string PropertyIdZero = "PropertyId should not be 0.";
            public const string PropertyTypeZero = "PropertyTypeId should not be 0.";
            public const string AreaIdZero = "AreaId should not be 0.";
            public const string LandNumberZero = "LandNumber should not be 0.";
            public const string BuildingIdZero = "BuildingId should not be 0.";
            public const string SearchTypeEmpty = "SearchType should not be empty.";
            public const string InvalidPropertyType = "Invalid PropertyTypeId.";
            public const string InvalidSearchType = "Invalid SearchType.";
            public const string LandNumberAreaIdRequired = "LandNumber is required and Area Id is required.";
            public const string BuildingNumberRequired = "BuildingNumber is required.";
            public const string UnitNumberRequired = "Building and UnitNumber are required.";
            public const string MunicipalityNumberRequired = "MunicipalityNumber and MunicipalitySubNumber is required.";
            public const string DeveloperLandNumberRequired = "DeveloperLandNumber is required.";
        }

        public struct TransactionErrors
        {
            public const string ProcedureIdZero = "ProcedureId cannot be Zero";
            public const string ProcedureIdYearNumZero = "ProcedureId, ProcedureYear or ProcedureNumber cannot be Zero";
            public const string TransactionDateEmpty = "Transaction date cannot be empty";
            public const string IncorrectDateFormat = "Date format is incorrect use dd/MM/yyyy";
            public const string TransactionMonthEmpty = "Transaction month cannot be empty";
            public const string TransactionYearEmpty = "Transaction year cannot be empty";
            public const string TransactionMonthFormat = "Only values between 01 to 12 or ALL are allowed";
            public const string TransactionYearFormat = "Only 4 digit integers are allowed";
        }

       

    }

}
