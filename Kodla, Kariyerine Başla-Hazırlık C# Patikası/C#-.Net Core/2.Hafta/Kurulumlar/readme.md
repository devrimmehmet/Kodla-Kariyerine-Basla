# .NET 5 Kurulumu

.NET Core ile uygulama geliştirmek için öncelikle SDK paketinin kurulması gerekir.

SDK veya Software Development Kit yazılım geliştirmek için gerekli olan derleyici, cli gibi araçları içeren bir pakettir.

## Windows

https://dotnet.microsoft.com/en-us/download/dotnet

Bu eğitimde .Net 5.0 Versiyonu kullanılmıştır.


## Linux
Linux tabanlı işletim sistemlerine kurulum Windows işletim sistemlerine kurulumdan farklıdır.

İlk olarak .NET Core için gerekli olan Repo işletim sistemine eklenir.

wget -q https://packages.microsoft.com/config/ubuntu/19.04/packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb

Repo eklendikten sonra repo içerisinde yer alan dotnet paketi kurularak kurulum tamamlanır.

<code>sudo apt-get install apt-transport-https sudo apt-get update sudo apt-get install dotnet-sdk-2.2

yum install rh-dotnet22 -y scl enable rh-dotnet22 bash</code>

NOT: Linux tabanlı işletim sistemlerinde kurulum Linux paket yöneticisine göre farklılık gösterir.

## Kontrol

.NET Core SDK kurulumu ile birlikte .NET Core projesi oluşturmak ve çalıştırmak için dotnet CLI (Command Line Interface) kurulumunu yapar.

Kurulum sonrası .NET Core işletim sistemini path veya çevre değişkenleri olarak adlandırılan alanına ekler.

Bu sayede işletim sistemlerinde yer alan komut yorumlayıcında (CMD, PowerShell, Bash vb.) aşağıdaki komut çalıştırılır.

* dotnet --version
    - İşletim sisteminde yer alan komut yorumlayıcısına yukarıda yer alan komut yazılıp çalıştırıldığında kurulan .NET Core sürümü yazılacaktır.

# VS Code Kurulumu

## Windows

VS Code Kurulum Dosyası'nı bilgisayarınıza indirin.

Kurulum dosyasını üzerine çift tıklayarak çalıştırın ve ileri butpnu yönergelerini takip ederek kurulumu tamamlayın.

Varsayılan olarak uygulama kurulum path'i: VS Code C:\users{kullanıcı adı}\AppData\ Local\Programs\Microsoft VS Code

VS Code'u başlatmak için Başlat menüsünü kullanabilir yada komut istemcisinden code . komutunu çalıştırabilirsiniz.

### ÖNEMLİ NOT: VS code ile C# geliştirirken ihtiyacımız olacak olan extension ların yüklenmesi gerekmektedir. Extension arama pencersinde belirtmiş olduğum Extension Id ler arama yaparak hızlıca bulabilirsiniz.

- .Net Core Tools (Extensison Id : formulahendry.dotnet)
- C# (Extension Id : ms-dotnettools.csharp)
- Ms Build Project Tools (Extension Id : tintoy.msbuild-project-tools)

## Linux

VS Code Linuw ortamda kurabilmenin en basit yönyemi Snap'tir. Daha önce kullanmayanlar için Snap; Linux kullanıcılarına özel olarak oluşturulmuş bir uygulama yükleme platformudur. Snap paketi olarak hazılanmış milyonlarca uygulamayı, hemen hemen tüm Linux ortamlara kolayca yükleyebilirsiniz.

<code>sudo snap install --classic code</code>

Kurulum tamamlandıktan sonra Snap, arka planda VS Code'u otomatik olarak güncellemeleri denetleyecek. Yeni bir güncelleme olduğunda, sizi bilgilendirecek ve onay verirseniz yükleyecek.

### NOT: VS Code'un, Snap haricindeki Linux kurulum seçenekleri hakkında daha fazla bilgi almak için Visual Studio Code on Linux sayfasını ziyaret edebilirsiniz.