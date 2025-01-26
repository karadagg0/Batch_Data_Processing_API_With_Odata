# Batch_Data_Processing_API_With_Odata

Bu proje, OData API'leri ile veri iþleme ve batch iþlemleri gerçekleþtirmek için kullanýlan bir örnek uygulamadýr. Proje, ASP.NET Core kullanarak OData ve batch iþleme özelliklerini içeren bir web API'si sunmaktadýr. OData, RESTful web servisleri üzerinde veri sorgulama, filtreleme ve iþlemleri daha verimli bir þekilde yapabilmek için kullanýlan bir protokoldür.

## OData Nedir?

OData (Open Data Protocol), RESTful web servisleri üzerinden veri sorgulama ve yönetimi yapabilmek için geliþtirilmiþ bir protokoldür. OData, veri üzerinde filtreleme, sýralama, sayfalama ve iliþkilendirilmiþ verileri alma gibi iþlemleri basitleþtirir. Bu protokol, bir API'nin veri setine eriþim saðlamak ve üzerinde iþlem yapabilmek için standartlaþtýrýlmýþ bir yöntem sunar.

OData'nýn baþlýca özellikleri þunlardýr:
- **Filtreleme (Filtering):** Veri üzerinde koþullara dayalý sorgular yapabilme.
- **Sýralama (Sorting):** Veriyi belirli bir düzende sýralama.
- **Sayfalama (Paging):** Veri kümesinin bir kýsmýna hýzlý eriþim saðlama.
- **Hesaplamalý Alanlar (Calculated Fields):** Veri kümesi üzerinde hesaplamalar yapabilme.
- **Ýliþkili Veri (Related Data):** Farklý veri kaynaklarý arasýndaki iliþkileri alabilme.

OData, veri eriþiminde esneklik saðlar ve API kullanýcýlarýnýn verileri istedikleri þekilde sorgulamalarýna olanak tanýr.

## Proje Özeti

Bu proje, OData protokolü ve batch iþlemlerini kullanarak veriyi etkili bir þekilde iþleme amacýný taþýr. Kullanýcýlar, API'ye çeþitli veri sorgularý gönderebilir ve `batch` iþlemleri ile birden fazla sorguyu ayný anda iþleyebilirler.

### Ana Özellikler
- **OData API:** OData kullanarak kullanýcý ve sipariþ verilerini sorgulama, filtreleme ve sýralama iþlemleri.
- **Batch Ýþlemleri:** Ayný anda birden fazla OData sorgusunu bir `POST` isteði ile gönderme ve iþlemleri topluca yapma.
- **Swagger Desteði:** API'nin kolayca test edilebilmesi için Swagger UI entegrasyonu.
- **Entity Framework Core:** Veritabaný iþlemleri için ORM.

## Proje Yapýsý

1. **UserController:** Kullanýcý verilerini almak için OData API'si saðlar. Bu controller, kullanýcýlarý ve iliþkili sipariþ verilerini sorgulamak için kullanýlýr.
2. **Program:** API'nin baþlatýlmasýný ve yapýlandýrýlmasýný yöneten ana sýnýf. OData ve batch iþleme yapýlandýrmalarý burada yapýlýr.
3. **DbContext:** Veritabaný baðlantýsý ve veri yönetimi için Entity Framework Core kullanýlýr.

## Teknolojiler

- **ASP.NET Core**: Web API'si için temel framework.
- **OData**: Verilere RESTful API üzerinden esnek ve güçlü eriþim saðlamak için kullanýlýr.
- **Entity Framework Core**: Veritabaný iþlemleri için ORM.
- **Swagger**: API'yi test etmek için kullanýcý dostu bir arayüz.

## Kurulum

### Gereksinimler

- .NET SDK 6.0 veya daha yenisi
- Visual Studio veya baþka bir C# geliþtirme ortamý



   Projeyi klonlayýn:

   ```bash
   git clone https://github.com/karadagg0/Batch_Data_Processing_API_With_Odata.git
   cd Batch_Data_Processing_API_With_Odata
