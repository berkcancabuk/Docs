# AssetsBundleStreaming
 
**1)`İlk başta Unity içinde tutmak istemediğiniz dosyaları prefab halina getirmeliyiz. Prefab yaptığımız dosyanın üzerine gelip Inspector penceresinin en alt kısmında AssetBundle olarak bulunan kısımda tıklayarak prefab objenin assetbundle ismini vermeliyiz.`**

![alt text](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/Assetbundlename.png)

**2)`Prefab dosyalarımıza verdiğimiz assetbunlde isimlerini bir dosya haline getirip internete atmamız gerekiyor. Bunun için ;
Unity assets klasörü içinde Editor adında bir dosya oluşturup bunun içinde CreateAssetBundle.cs adında bir script açıyoruz.`**

![alt text](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/EditorCreateAssetBundle.png)

**3)` Bu açtığımız scriptin içine `[CreateAssetBundles](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/CreateAssetBundles.cs)** `bu kodu yapıştırıyoruz. Bu scriptte bir hat oluşturuyor BuildAssetsBundlestan ve oluşabilecek bütün hedef olan platformlarda çekebileceksiniz. Yani android,ios vb gibi`

**4) `AssetBundles Klasörünü oluşturabilmek için Unity üzerinden Assets sekmesinde en altta build AssetsBundles adını göreceksiniz ona tıkladığınızda 20-60 saniye aralığında size bir dosya oluşturacak ve bu dosya Project/Assets/StreamingAssets adı altında oluşmuş olacaktır. `** 

![alt text](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/AssetSekmesi.png)

**4) `Oluşturduğumuz "StreamingAssets" adındaki assetBundle unity dosyalarının içinden çıkartıp masaüstümüze alıyoruz. Aldıktan sonra bir online sunucu oluşturup bu sunucu içine bu dosyaları atmamız gerekiyor. Dosyaların VerdiğimizAssetBundleName.manifest olan dosyamız bizim version numarasına ulaşacağımız dosyadır. Yalnızca Verdiğimiz AssetBundleName dosyamız ise bizim internet üzerinden çekeceğimiz prefab dosyamızdır.`**

**5) `Attığımız dosyaları nasıl çekeriz? Atılan dosyaları yeni bir API adlı script oluşturarak bu scriptin içine`[APIScript](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/API.cs) `verilen kodları ekliyoruz yanda açıklamaları yazmaktadır`**

**6) `UNUTMAYIN LİSTE YÖNTEMİ İLE YAPTIĞIMIZ İÇİN VERSİON NUMARASI VE BUNDLE İSMİNİ GİRMENİZ GEREKİYOR.
ContentController adında bir script oluşturup` [ContentController](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/ContentController.cs) `kod satırlarını girmeniz gerekiyor. Bu scrtip içerikleri denetleyip yüklenen objenin ismini yazdırıyor. Aşağıdaki LoadContent() fonksiyonunu bir buton veya startta çağırarak scripti başlatabilirsiniz.`**

