namespace Portfolio.Domain.Common.Error;

public static partial class Errors {

    public static class Authentication {

        public static ErrorOr.Error InvalidCredentials => ErrorOr.Error.Validation
        (
            code: "Auth.InvalidCredentials",
            description: "The credentials provided are invalid."
        );
    }
}