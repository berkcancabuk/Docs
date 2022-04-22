# ALL DOCS

1.  **[Streaming Assets Bundle](https://github.com/berkcancabuk/Docs#streaming-assets-bundle)**
    - **[AssetBundleİsimlendirme](https://github.com/berkcancabuk/Docs/edit/main/README.md#1i%CC%87lk-ba%C5%9Fta-unity-i%C3%A7inde-tutmak-istemedi%C4%9Finiz-dosyalar%C4%B1-prefab-haline-getirmeliyiz-prefab-yapt%C4%B1%C4%9F%C4%B1m%C4%B1z-dosyan%C4%B1n-%C3%BCzerine-gelip-inspector-penceresinin-en-alt-k%C4%B1sm%C4%B1nda-assetbundle-olarak-bulunan-k%C4%B1s%C4%B1mda-t%C4%B1klayarak-prefab-objenin-assetbundle-ismini-vermeliyiz)**
    - **[Create Assets Scriptini Oluşturma](https://github.com/berkcancabuk/Docs/edit/main/README.md#2-prefab-dosyalar%C4%B1m%C4%B1za-verdi%C4%9Fimiz-assetbunlde-isimlerini-bir-dosya-haline-getirip-internete-atmam%C4%B1z-gerekiyor-bunun-i%C3%A7in-unity-assets-klas%C3%B6r%C3%BC-i%C3%A7inde-editor-ad%C4%B1nda-bir-dosya-olu%C5%9Fturup-bunun-i%C3%A7inde-createassetbundlecs-ad%C4%B1nda-bir-script-a%C3%A7%C4%B1yoruz)**
    - **[Streaming Assets Bundle Klasörünü Oluşturma](https://github.com/berkcancabuk/Docs/edit/main/README.md#3-assetbundles-klas%C3%B6r%C3%BCn%C3%BC-olu%C5%9Fturabilmek-i%C3%A7in-unity-%C3%BCzerinden-assets-sekmesinde-en-altta-build-assetsbundles-ad%C4%B1n%C4%B1-g%C3%B6receksiniz-ona-t%C4%B1klad%C4%B1%C4%9F%C4%B1n%C4%B1zda-20-60-saniye-aral%C4%B1%C4%9F%C4%B1nda-size-bir-dosya-olu%C5%9Fturacak-ve-bu-dosya-projectassetsstreamingassets-ad%C4%B1-alt%C4%B1nda-olu%C5%9Fmu%C5%9F-olacakt%C4%B1r-olu%C5%9Fturdu%C4%9Fumuz-streamingassets-ad%C4%B1ndaki-assetbundle-unity-dosyalar%C4%B1n%C4%B1n-i%C3%A7inden-%C3%A7%C4%B1kart%C4%B1p-masa%C3%BCst%C3%BCm%C3%BCze-al%C4%B1yoruz-ald%C4%B1ktan-sonra-bir-online-sunucu-olu%C5%9Fturup-bu-sunucu-i%C3%A7ine-bu-dosyalar%C4%B1-atmam%C4%B1z-gerekiyor-dosyalar%C4%B1n-verdi%C4%9Fimizassetbundlenamemanifest-olan-dosyam%C4%B1z-bizim-version-numaras%C4%B1na-ula%C5%9Faca%C4%9F%C4%B1m%C4%B1z-dosyad%C4%B1r-yaln%C4%B1zca-verdi%C4%9Fimiz-assetbundlename-dosyam%C4%B1z-ise-bizim-internet-%C3%BCzerinden-%C3%A7ekece%C4%9Fimiz-prefab-dosyam%C4%B1zd%C4%B1r-)**
    - **[Atılan Dosyaları Nasıl İndirebiliriz](https://github.com/berkcancabuk/Docs/edit/main/README.md#5-att%C4%B1%C4%9F%C4%B1m%C4%B1z-dosyalar%C4%B1-nas%C4%B1l-%C3%A7ekeriz-at%C4%B1lan-dosyalar%C4%B1-yeni-bir-api-adl%C4%B1-script-olu%C5%9Fturarak-bu-scriptin-i%C3%A7ineapiscript-verilen-kodlar%C4%B1-ekliyoruz-yanda-a%C3%A7%C4%B1klamalar%C4%B1-yazmaktad%C4%B1r)**
    - **[Denetleyici Nasıl Oluşturulur Ve Nasıl İndirme Başlatılır](https://github.com/berkcancabuk/Docs/edit/main/README.md#6-unutmayin-li%CC%87ste-y%C3%B6ntemi%CC%87-i%CC%87le-yapti%C4%9Fimiz-i%CC%87%C3%A7i%CC%87n-versi%CC%87on-numarasi-ve-bundle-i%CC%87smi%CC%87ni%CC%87-gi%CC%87rmeni%CC%87z-gereki%CC%87yor-contentcontroller-ad%C4%B1nda-bir-script-olu%C5%9Fturup-contentcontroller-kod-sat%C4%B1rlar%C4%B1n%C4%B1-girmeniz-gerekiyor-bu-script-i%C3%A7erikleri-denetleyip-y%C3%BCklenen-objenin-ismini-yazd%C4%B1r%C4%B1yor-script-i%C3%A7indeki-loadcontent-fonksiyonunu-bir-buton-veya-starta-koyarak-%C3%A7al%C4%B1%C5%9Ft%C4%B1rabiliriz)**

## Streaming Assets Bundle

### **1.`İlk başta Unity içinde tutmak istemediğiniz dosyaları prefab haline getirmeliyiz. Prefab yaptığımız dosyanın üzerine gelip Inspector penceresinin en alt kısmında AssetBundle olarak bulunan kısımda tıklayarak prefab objenin assetbundle ismini vermeliyiz.`**

![alt text](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/Assetbundlename.png)

### **2. `Prefab dosyalarımıza verdiğimiz assetbunlde isimlerini bir dosya haline getirip internete atmamız gerekiyor. Bunun için Unity assets klasörü içinde Editor adında bir dosya oluşturup bunun içinde CreateAssetBundle.cs adında bir script açıyoruz.`**

![alt text](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/EditorCreateAssetBundle.png)

### `Bu açtığımız scriptin içine `[CreateAssetBundles](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/CreateAssetBundles.cs)`bu kodu yapıştırıyoruz. Bu scriptte bir hat oluşturuyor BuildAssetsBundlestan ve oluşabilecek bütün hedef olan platformlarda çekebileceksiniz. Yani android,ios vb gibi`**

### **3) `AssetBundles Klasörünü oluşturabilmek için Unity üzerinden Assets sekmesinde en altta build AssetsBundles adını göreceksiniz ona tıkladığınızda 20-60 saniye aralığında size bir dosya oluşturacak ve bu dosya Project/Assets/StreamingAssets adı altında oluşmuş olacaktır. Oluşturduğumuz "StreamingAssets" adındaki assetBundle unity dosyalarının içinden çıkartıp masaüstümüze alıyoruz. Aldıktan sonra bir online sunucu oluşturup bu sunucu içine bu dosyaları atmamız gerekiyor. Dosyaların VerdiğimizAssetBundleName.manifest olan dosyamız bizim version numarasına ulaşacağımız dosyadır. Yalnızca Verdiğimiz AssetBundleName dosyamız ise bizim internet üzerinden çekeceğimiz prefab dosyamızdır. `**

![alt text](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/AssetSekmesi.png)



### **5) `Attığımız dosyaları nasıl çekeriz? Atılan dosyaları yeni bir API adlı script oluşturarak bu scriptin içine`[APIScript](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/API.cs) `verilen kodları ekliyoruz yanda açıklamaları yazmaktadır`**

### **6) `UNUTMAYIN LİSTE YÖNTEMİ İLE YAPTIĞIMIZ İÇİN VERSİON NUMARASI VE BUNDLE İSMİNİ GİRMENİZ GEREKİYOR. ContentController adında bir script oluşturup` [ContentController](https://github.com/berkcancabuk/AssetsBundleStreaming/blob/main/ContentController.cs) `kod satırlarını girmeniz gerekiyor. Bu script içerikleri denetleyip yüklenen objenin ismini yazdırıyor. Script içindeki LoadContent() fonksiyonunu bir buton veya starta koyarak çalıştırabiliriz.`**
