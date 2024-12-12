# ARprojesi

## **Kurulum ve Çalıştırma**

### **1. Gereksinimler**
- **Unity**: Proje, Unity 2020 veya daha yeni bir sürümle geliştirildi. Unity'nin AR Foundation ve ilgili eklentilerle birlikte kurulması gerekir.
- **Mobil cihaz**: AR destekli bir Android cihaz gereklidir.

---

### **2. Gerekli Paketlerin Kurulumu**
1. Unity'de, `Window > Package Manager` menüsüne gidin.
2. Aşağıdaki paketlerin kurulu olduğundan emin olun:
   - **AR Foundation**
   - **ARCore XR Plugin** (Android için)
3. Eğer bu paketler kurulu değilse, **Package Manager** üzerinden yükleyin.

---

### **3. Projenin Build Edilmesi**
1. Unity'de `File > Build Settings` menüsüne gidin.
2. Platformu **Android** olarak ayarlayın ve "Switch Platform" düğmesine tıklayın.
3. "Scenes in Build" kısmında sahnenizin eklendiğinden emin olun.
   - Eğer sahne listede yoksa, `Add Open Scenes` düğmesine tıklayın.
4. **Player Settings** altında şunları kontrol edin:
   - **Minimum API Level**: Android 7.0 (API Level 24) veya daha üstü.
   - **XR Plug-in Management**: Android sekmesinde **ARCore** işaretli olmalıdır.
5. "Build" düğmesine tıklayın ve APK dosyasını oluşturun.
6. APK dosyasını Android cihazınıza yükleyin.

---

## **Kullanım**
1. Uygulamayı Android cihazınıza yükleyin ve çalıştırın.
2. Kamerayı açar açmaz güneş sistemi algılanır ve gezegenler güneş etrafında dönmeye başlar.
3. Kullanıcı, cihazını hareket ettirerek güneş sistemini farklı açılardan gözlemleyebilir.

---

## **Bilinen Sorunlar**
- Gezegenlerin pozisyonları ve yörüngeleri, cihazın hareketine bağlı olarak değişebilir.
- Performans, eski Android cihazlarda düşük olabilir.

---

## **Gelecek Geliştirmeler**
- Gezegenlerin dokunarak yerleştirilebilmesi sağlanabilir.
- Gezegenlerin dönme hareketleri eklenebilir.
- Güneşin ışık ve sıcaklık efekti artırılabilir.

---
