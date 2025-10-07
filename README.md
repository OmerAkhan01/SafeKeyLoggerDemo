# 🧠 Safe Keylogger Demo (C# .NET 4.7.2)

Bu proje, C# Windows Forms (.NET Framework 4.7.2) kullanılarak geliştirilmiş **güvenli bir keylogger ödevidir**.  
Uygulama yalnızca **kullanıcı rızası (onayı)** alındığında tuş girişlerini kaydeder ve kayıtları yerel bir log dosyasına yazar.  
İsteğe bağlı olarak log dosyasını e-posta ile gönderme özelliği de bulunmaktadır.

---

## 🎥 Uygulama Tanıtım Videosu
Projenin çalışma videosunu buradan izleyebilirsiniz 👇  
🔗 [YouTube - Ödev Tanıtım Videosu (Gizli)](https://youtu.be/3saVRoHhD1g)

---

## ⚙️ Özellikler
✅ Kullanıcı onayı olmadan kayıt başlatılamaz.  
✅ Tuş vuruşlarını zaman damgası ile log dosyasına kaydeder.  
✅ Log dosyası e-posta yoluyla gönderilebilir.  
✅ Oturum sonlandırıldığında kayıt düzgün biçimde kapanır.  
✅ Basit, anlaşılır bir arayüze sahiptir.

---

## 🪄 Kullanım
1. Uygulamayı çalıştır.  
2. “Kullanıcı onayını” (checkbox) işaretle.  
3. “Kayıt Başlat” butonuna tıkla.  
4. İstediğin tuşlara bas → kayıt `keystrokes_log.txt` dosyasına yazılır.  
5. “Kayıt Durdur” dediğinde e-posta gönderilir (eğer yapılandırılmışsa).

---

## 🛠️ Teknolojiler
- **C# (.NET Framework 4.7.2)**  
- **Windows Forms (WinForms UI)**  
- **System.IO, System.Net.Mail** kütüphaneleri  

---

## 📧 E-posta Özelliği
Uygulama, log dosyasını e-posta ile gönderebilmek için Gmail’in **uygulama şifresi** özelliğini kullanır.  
Bu işlem yalnızca kullanıcının kendine test amaçlı mail atması içindir.  
Şifre veya e-posta bilgileri dışarıya paylaşılmaz.

---

## 🔒 Yasal Uyarı
Bu uygulama **yalnızca eğitim amaçlıdır**.  
Herhangi bir izinsiz kullanım, veri toplama veya kötüye kullanım **kesinlikle yasaktır**.  
Proje, etik bilişim ilkeleri çerçevesinde hazırlanmıştır.

---

© 2025 – Ömer tarafından hazırlanmıştır.
