namespace NETCoreMVCBlog.Models
{
    public class Yorum
    {
        public int Id { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }
    }
}
