namespace KitabeviApp.Models
{
    public class Yazar
    {
        public int Id { get; set; }
        // [Required(ErrorMessage ="Lütfen adı boş bırakmayınız.")]  // Ad alanının required olmasını istedik. Verilecek kurallara uyulması gerektiğini söyleyecez. debug yaparken modelsatate isvalid kısmına bakacaz. bunu uygulmak için Kitapekle viewimizde ad kısmına span ekleyip uyarı vermesini istedik. bunu comment yapma nedenimiz YazarvİEWDE BUNU YAPTIK değşiklik yapmak istediğimizde kolaylık sağlamak için.
        public string Ad { get; set; }
        //[Required(ErrorMessage ="Lütfen doğum yılını boş bırakmayınız.")]
        public int? DogumYili { get; set; }   // soru işaretini boş bıraktığındaa valuesi string oluyor bu durumu düzletmek istedik.
        public char Cinsiyet { get; set; }
    }
}