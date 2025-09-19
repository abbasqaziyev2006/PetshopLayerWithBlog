namespace Petshop.BLL.ViewModels
{
    public class BioViewModel
    {
        public string? LogoUrl { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class BioCreateViewModel
    {
        public string LogoUrl { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
    }

    public class BioUpdateViewModel
    {
        public string LogoUrl { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public bool IsDeleted { get; set; }
    }
}

