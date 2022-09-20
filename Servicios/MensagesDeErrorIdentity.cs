using Microsoft.AspNetCore.Identity;

namespace Presupuesto.Servicios
{
    public class MensagesDeErrorIdentity : IdentityErrorDescriber
    {
        public override IdentityError DefaultError(){return new IdentityError { Code = nameof(DefaultError),Description=$"Ha ocurrido un error." };}
        public override IdentityError ConcurrencyFailure() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        public override IdentityError PasswordMismatch() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        public override IdentityError InvalidToken() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        public override IdentityError LoginAlreadyAssociated() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        public override IdentityError InvalidUserName(string userName) { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        public override IdentityError InvalidEmail(string email) { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        public override IdentityError DuplicateUserName(string userName) { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        //public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        //public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        //public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        //public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        //public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        //public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }
        //public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." }; }

    }
}
