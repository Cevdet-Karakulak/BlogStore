# 🧠 BlogStore | AI Destekli Katmanlı ASP.NET Core Blog Platformu 🚀

BlogStore, ASP.NET Core MVC, Entity Framework Core ve Hugging Face AI entegrasyonu ile geliştirilmiş modern bir blog platformudur. Kullanıcılar makaleleri okuyabilir, yorum yapabilir ve admin paneli üzerinden içerikleri yönetebilir. Yapay zeka destekli yorum filtreleme ve çok dillilik özellikleri ile güvenli ve akıllı bir blog deneyimi sunar.

---

## 🎯 Hedefler
- Kullanıcıların güvenli ve interaktif bir blog deneyimi yaşaması  
- Makale, yorum ve kategori yönetimini kolaylaştırmak  
- Yapay zeka ile toksik yorumları otomatik olarak engellemek  
- SEO uyumlu ve dinamik URL yapısı ile içeriklerin erişilebilir olmasını sağlamak  

---

## 🏗️ Katmanlı Mimari

| Katman | Açıklama |
|--------|----------|
| **WebUI / Presentation Layer 🖥️** | MVC Controller, Razor View, ViewModel. AJAX & jQuery ile dinamik yorum sistemi. |
| **Business Layer ⚙️** | İş mantığı, servisler, FluentValidation ile girdi doğrulama. |
| **Data Access Layer 💾** | EF Core ile CRUD işlemleri ve özel sorgular. Generic Repository Pattern uygulanmıştır. |
| **Entity Layer 📦** | AppUser, Article, Category, Tag, Comment entity sınıfları. |

---

## 🛠️ Kullanılan Teknolojiler

<p align="center">
  <!-- Backend -->
  <img src="https://img.shields.io/badge/.NET%208-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/ASP.NET%20Core-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" />
  <img src="https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=entity-framework&logoColor=white" />

  <!-- Database -->
  <img src="https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />

  <!-- Frontend -->
  <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" />
  <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white" />
  <img src="https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white" />
  <img src="https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white" />

  <!-- AI & API -->
  <img src="https://img.shields.io/badge/ToxicBERT-FF6F61?style=for-the-badge" />
  <img src="https://img.shields.io/badge/Helsinki-NLP-1ABC9C?style=for-the-badge" />
  
  <!-- Diğer -->
  <img src="https://img.shields.io/badge/AutoMapper-512BD4?style=for-the-badge&logo=automapper&logoColor=white" />
  <img src="https://img.shields.io/badge/Chart.js-FF6384?style=for-the-badge&logo=chart.js&logoColor=white" />
  <img src="https://img.shields.io/badge/FluentValidation-007ACC?style=for-the-badge&logo=fluentbit&logoColor=white" />
</p>

---

## ✨ Özellikler

| Özellik | Açıklama |
|---------|----------|
| 📰 Makale Yönetimi | Oluşturma, düzenleme, silme, kategori ve etiket yönetimi |
| 💬 AI Destekli Yorum Sistemi | Toksik içerik kontrolü, sayfa yenilenmeden yorum ekleme |
| 🔐 Kullanıcı Yönetimi | Identity ile giriş/kayıt, profil yönetimi, roller: Admin/Kullanıcı/Ziyaretçi |
| 🎛️ Admin Paneli | Dashboard, makale listesi, kategori & etiket yönetimi |
| 🏷️ SEO & Slug | URL’lerde makale ID yerine slug kullanımı |
| 📊 İstatistikler | Chart.js ile admin panelinde grafikler |

---

## 🧩 Veritabanı Varlıkları & İlişkiler

| Entity | Açıklama |
|--------|----------|
| **AppUser 👤** | Kullanıcı bilgileri |
| **Article 📝** | Makale başlığı, içeriği, görseli, yazarı |
| **Category 🗂️** | Makaleleri kategorilere ayırır |
| **Tag 🏷️** | Makalelere etiket ekler |
| **Comment 💬** | Makale altına yazılan kullanıcı yorumları |

---
## 📸 Ekran Görselleri
<img width="1553" height="892" alt="Image" src="https://github.com/user-attachments/assets/0e59c74a-37cc-4fa4-8af0-a83f4725577d" />

<img width="1544" height="897" alt="Image" src="https://github.com/user-attachments/assets/5ca88a57-15dc-40b9-b11b-37890e0b8791" />

<img width="1489" height="866" alt="Image" src="https://github.com/user-attachments/assets/eec53189-4551-4027-a897-73e4586e9b8e" />

<img width="1381" height="905" alt="Image" src="https://github.com/user-attachments/assets/2270694a-ac7b-4df3-982d-ff5a6f4c668b" />

<img width="1915" height="772" alt="Image" src="https://github.com/user-attachments/assets/81b77a69-482e-4811-bfa9-bdbec2135671" />

<img width="1893" height="912" alt="Image" src="https://github.com/user-attachments/assets/a550b9a8-5178-45de-ad60-0c01941e2484" />

<img width="1571" height="851" alt="Image" src="https://github.com/user-attachments/assets/8d927023-3ceb-437f-8625-e04561302317" />

<img width="1916" height="823" alt="Image" src="https://github.com/user-attachments/assets/57864ba0-1d77-40c6-a079-6c351bd498ed" />

<img width="1742" height="896" alt="Image" src="https://github.com/user-attachments/assets/bfdc4f22-9766-48f5-938d-702d1ba35f70" />

<img width="1540" height="828" alt="Image" src="https://github.com/user-attachments/assets/c775afcc-ee9d-4d80-8907-5acc6f0866e8" />

<img width="1591" height="820" alt="Image" src="https://github.com/user-attachments/assets/08de3350-6a67-4d3c-bdea-89206c6520dc" />

---

## ⚙️ Kurulum & Çalıştırma

```bash
# Depoyu klonlayın
git clone https://github.com/Cevdet-Karakulak/BlogStore.git
cd BlogStore

# NuGet paketlerini yükleyin
dotnet restore

# Veritabanını güncelleyin (Migrations ile)
dotnet ef database update

# Uygulamayı çalıştırın
dotnet run
💡 Not: Hugging Face API anahtarınızı appsettings.json veya Secret Manager üzerinden ekleyin.



