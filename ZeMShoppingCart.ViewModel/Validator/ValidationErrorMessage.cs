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

        public struct ParticipantErrors
        {
            public const string ParticipantZero = "ParticipantId should not be 0.";
            public const string ParticipantNumberEmpty = "ParticipantNumber should not be empty.";
            public const string ParticipantNumberNumeric = "ParticipantNumber should not be numeric.";
            public const string IdNumberNull = "If IdentityTypeId is set for passport then IdNumber cannot be empty.";
        }

        public struct DeveloperErrors
        {
            public const string DeveloperZero = "DeveloperId should not be 0.";
            public const string DeveloperName = "DeveloperName should not be empty.";
            public const string RequestedLanguage = "RequestedLanguage should be either en or ar.";
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

        public struct LookupErrors
        {
            public const string LookupTypeEmpty = "LookupType cannot be empty";
            public const string InvalidLookupType = "Not a valid lookup type";
        }

        public struct RentalIndexErrors
        {
            public const string AreaIdEmpty = "AreaId should not be 0.";
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

        public struct TrustAccountBankErrors
        {
            public const string BankParticipantIdEmpty = "BankParticipantId cannot be Empty";
            public const string BankParticipantIdZero = "BankParticipantId cannot be Zero";
        }

        public struct BrokerErrors
        {
            public const string RealEstateZero = "Real Esate Id cannot be zero";
        }
    }

}
