# Batch_Data_Processing_API_With_Odata

Bu proje, OData API'leri ile veri i�leme ve batch i�lemleri ger�ekle�tirmek i�in kullan�lan bir �rnek uygulamad�r. Proje, ASP.NET Core kullanarak OData ve batch i�leme �zelliklerini i�eren bir web API'si sunmaktad�r. OData, RESTful web servisleri �zerinde veri sorgulama, filtreleme ve i�lemleri daha verimli bir �ekilde yapabilmek i�in kullan�lan bir protokold�r.

## OData Nedir?

OData (Open Data Protocol), RESTful web servisleri �zerinden veri sorgulama ve y�netimi yapabilmek i�in geli�tirilmi� bir protokold�r. OData, veri �zerinde filtreleme, s�ralama, sayfalama ve ili�kilendirilmi� verileri alma gibi i�lemleri basitle�tirir. Bu protokol, bir API'nin veri setine eri�im sa�lamak ve �zerinde i�lem yapabilmek i�in standartla�t�r�lm�� bir y�ntem sunar.

OData'n�n ba�l�ca �zellikleri �unlard�r:
- **Filtreleme (Filtering):** Veri �zerinde ko�ullara dayal� sorgular yapabilme.
- **S�ralama (Sorting):** Veriyi belirli bir d�zende s�ralama.
- **Sayfalama (Paging):** Veri k�mesinin bir k�sm�na h�zl� eri�im sa�lama.
- **Hesaplamal� Alanlar (Calculated Fields):** Veri k�mesi �zerinde hesaplamalar yapabilme.
- **�li�kili Veri (Related Data):** Farkl� veri kaynaklar� aras�ndaki ili�kileri alabilme.

OData, veri eri�iminde esneklik sa�lar ve API kullan�c�lar�n�n verileri istedikleri �ekilde sorgulamalar�na olanak tan�r.

## Proje �zeti

Bu proje, OData protokol� ve batch i�lemlerini kullanarak veriyi etkili bir �ekilde i�leme amac�n� ta��r. Kullan�c�lar, API'ye �e�itli veri sorgular� g�nderebilir ve `batch` i�lemleri ile birden fazla sorguyu ayn� anda i�leyebilirler.

### Ana �zellikler
- **OData API:** OData kullanarak kullan�c� ve sipari� verilerini sorgulama, filtreleme ve s�ralama i�lemleri.
- **Batch ��lemleri:** Ayn� anda birden fazla OData sorgusunu bir `POST` iste�i ile g�nderme ve i�lemleri topluca yapma.
- **Swagger Deste�i:** API'nin kolayca test edilebilmesi i�in Swagger UI entegrasyonu.
- **Entity Framework Core:** Veritaban� i�lemleri i�in ORM.

## Proje Yap�s�

1. **UserController:** Kullan�c� verilerini almak i�in OData API'si sa�lar. Bu controller, kullan�c�lar� ve ili�kili sipari� verilerini sorgulamak i�in kullan�l�r.
2. **Program:** API'nin ba�lat�lmas�n� ve yap�land�r�lmas�n� y�neten ana s�n�f. OData ve batch i�leme yap�land�rmalar� burada yap�l�r.
3. **DbContext:** Veritaban� ba�lant�s� ve veri y�netimi i�in Entity Framework Core kullan�l�r.

## Teknolojiler

- **ASP.NET Core**: Web API'si i�in temel framework.
- **OData**: Verilere RESTful API �zerinden esnek ve g��l� eri�im sa�lamak i�in kullan�l�r.
- **Entity Framework Core**: Veritaban� i�lemleri i�in ORM.
- **Swagger**: API'yi test etmek i�in kullan�c� dostu bir aray�z.

## Kurulum

### Gereksinimler

- .NET SDK 6.0 veya daha yenisi
- Visual Studio veya ba�ka bir C# geli�tirme ortam�



   Projeyi klonlay�n:

   ```bash
   git clone https://github.com/karadagg0/Batch_Data_Processing_API_With_Odata.git
   cd Batch_Data_Processing_API_With_Odata
