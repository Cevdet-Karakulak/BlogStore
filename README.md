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

- ASP.NET Core MVC & C#  
- Entity Framework Core  
- Identity ile kullanıcı yönetimi  
- Hugging Face AI (toxicity detection & multi-language support)  
- AJAX & jQuery ile dinamik yorum sistemi  
- Chart.js ile admin panel istatistikleri  

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
<img width="1553" height="892" alt="Image" src="https://github.com/user-attachments/assets/6605723d-766f-4def-b496-94704a660b00" />

<img width="1544" height="897" alt="Image" src="https://github.com/user-attachments/assets/dfe3d910-4203-4a74-a12a-854cb195b1e7" />

<img width="1489" height="866" alt="Image" src="https://github.com/user-attachments/assets/81903ff3-41a2-4f2b-9051-f3af6012085a" />

<img width="1381" height="905" alt="Image" src="https://github.com/user-attachments/assets/61eb33fa-cc2a-4594-b01a-8c04b957d58e" />

<img width="1571" height="851" alt="Image" src="https://github.com/user-attachments/assets/ce412a83-9b29-4a79-aa14-52d56dcecf78" />

<img width="1893" height="912" alt="Image" src="https://github.com/user-attachments/assets/dc8853f7-b6fd-4488-8d45-dbeba7b71bd9" />

<img width="1915" height="772" alt="Image" src="https://github.com/user-attachments/assets/d8cf608e-002c-4232-8bff-d4f56b434974" />

<img width="1916" height="823" alt="Image" src="https://github.com/user-attachments/assets/68eaa1f1-41cc-43b9-a9e0-3a18dfa74351" />

<img width="1849" height="895" alt="Image" src="https://github.com/user-attachments/assets/ee42ff6d-fb40-49cd-93cc-a4b8837160aa" />

<img width="1742" height="896" alt="Image" src="https://github.com/user-attachments/assets/6b192488-5b66-48da-8344-4eae71055dec" />

<img width="1591" height="820" alt="Image" src="https://github.com/user-attachments/assets/363ea102-4f0c-4a2a-bf6f-a22f4dd7c165" />

<img width="1540" height="828" alt="Image" src="https://github.com/user-attachments/assets/15bc9847-b955-45bf-a937-b6f8e5b6aa57" />
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



