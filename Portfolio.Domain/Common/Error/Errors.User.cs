namespace Portfolio.Domain.Common.Error;

public static partial class Errors {

    public static class User {

        public static ErrorOr.Error DuplicateEmail => ErrorOr.Error.Conflict
        (
            code: "User.DuplicateEmail",
            description: "A user with the same email already exists."
        );
    }
}