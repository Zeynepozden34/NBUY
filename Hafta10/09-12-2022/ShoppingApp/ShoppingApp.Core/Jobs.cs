namespace ShoppingApp.Core
{
    public static class Jobs //URL OLUŞTURULACAK.
    {

        public static string InitUrL(string url)
        {
            #region Açıklamalar
            /* BU metot kendisine gelen url değişkeninin
            1 - Latin alfabesine çevrilen problem çıkaran İ-i ı-i gibi dönüşünleri yapacak
            2-türkçe karakter yerine latin albesindeki karşılıklarını koyacak
            3-Boşluklar yerine - koyacak
            4-(.),(/) gibi karakterleri kaldıracak
            */
            #endregion
            #region Sorunlu karakterler düzeltiliyor
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");
            #endregion

            #region küçük harfe dönüştürüldü
            url = url.ToLower();
            #endregion

            #region Türkçe karakterleri dönüştürdük
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            #endregion
            #region Boşuklar tire ile değiştirildi
            url = url.Replace(" ", "-");
            #endregion
            #region Sorunlu karakterler kaldırılıyor           
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            url = url.Replace("{", "");
            url = url.Replace("}", "");
            #endregion
            return url;

        }
    }
}