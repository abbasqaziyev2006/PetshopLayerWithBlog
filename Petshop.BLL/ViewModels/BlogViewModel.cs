namespace Petshop.BLL.ViewModels;

public class BlogViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string ImageName { get; set; } = null!;
    public DateTime PublishDate { get; set; }
}

public class CreateBlogViewModel
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string ImageName { get; set; } = null!;
    public DateTime PublishDate { get; set; }
}

public class UpdateBlogViewModel
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string ImageName { get; set; } = null!;
    public DateTime PublishDate { get; set; }
}

