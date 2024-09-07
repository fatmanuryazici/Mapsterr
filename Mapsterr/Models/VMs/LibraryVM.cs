namespace Mapsterr.Models.VMs
{
    public class LibraryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookVM> Books { get; set; }
    }
}
