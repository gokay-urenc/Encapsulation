using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Kapsulleme_
{
    // Class erişim seviyesi varsayılan(default) olarak internal'dır. Gözükmez.
    // Class erişim seviyesi private veya protected olamaz.
    class Class1
    {
    }
}
/* Kapsülleme, bir üyenin veya class'ın dışarıya karşı(class'ın dışına) korunmasıdır.
   Bir üye dışarıya kapatılıyorsa bu üye korunuyor demektir.
   Üyeleri kapsüllemek için Access Modifiers(Erişim Belirleyiciler)'e ihtiyaç duyulur.
   Access Modifiers: Bir class veya üyenin sınıf dışına veya proje dışına açmak veya kapatmak
   için kullanılır. Her tanımın default bir erişim seviyesi vardır. Class içerisindeki
   üyelerin tanımı belirtilmezse erişim seviyeleri private'dir.
   Private(Özel): Sadece class'a özeldir. Class içerisinden erişmek için kullanılır. Dışarıya
   kullanıma kapalıdır.
   Protected(Korunan): Sadece class ve class'tan miras alan classlar tarafından erişim için
   kullanılır.
   Internal(İç): Sadece tanımlandığı projeden erişilmek için kullanılır.
   Public(Genel): Geçerli proje ve diğer projelerden de erişmek için kullanılır.
   Property'deki get ve set methodtur ve bu methodların içleri tekrar doldurulabilir.
   Not: prop yazıp 2 kere tab basmak veya propfull yazıp 2 kere tab basmak kestirme yoldur.
*/