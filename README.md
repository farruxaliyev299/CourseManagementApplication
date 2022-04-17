       Course managment application
Application işə düşdüyü zaman console pəncərəsində istifadəçinin icra edə biləcəyi proseslər göstərilir və istifadəçidən bunlardan birinin seçilməsi tələb olunur.


1. Yeni qrup yarat - bu əməliyyat seçildikdə istifadəçidən yeni qrup yaradılması üçün lazımi məlumatları console-dan daxil etməsi istənilməlidir.
Daxil edilən dəyər qrup şərtlərinə uyğun olmasa yenidən daxil etməsi tələb olunmalıdır.

2. Qrupların siyahısını göstər - bu əməliyyat seçildikdə console pəncərəsinə sistemdə var olan bütün qrupların
nömrələri, növləri və tələbə sayları göstərilməlidir

3. Qrup üzərində düzəliş etmək - bu əməliyyat seçildikdə birinci növbədə istifadəçidən üzərində dəyişiklik ediləcək
qrup nömrəsini daxil etməsi tələb olunmalıdır, daha sonra həmin qrupun yeni nömrəsinin
daxil edilməsi tələb olunmalıdır. Qrupun yalnız nömrəsi dəyişdirilə bilər. Bu halda sistemdə
yeni adda qrup olub olmadığı yoxlanılmalıdır. Əgər o adda qrup varsa istifadəçiyə xəta mesajı verib yenidən daxil etməsi tələb olunmalıdır.


4. Qrupdakı tələbələrin siyahısını göstər - bu əməliyyat seçildikdə istifadəçidən hansı qrupdakı tələəbələrin siyahısını
görmək istəyirsə həmin qrupun nömrəsini daxil etməsi istənilməlidir. Əgər daxil edilən
nömrəli qrup yoxdursa istifadəçiyə xəta mesajı göstərib proses menu-suna qaytarmalıdır.

5. Bütün tələbələrin siyahısını göstər - bu əməliyyat seçildikdə sistem daxilindəki bütün tələbələrin siyahısı göstərilməlidir. (Tələbə adı, qrup nömrəsi, online olub olmamağı)

6. Tələbə yarat - bu əməliyyat seçildikdə istifadəçidən tələbə yaranması üçün lazım olan məlumatların daxil edilməsi tələb olunmalıdır.





Student calss:

- Fullname
- Group No
- Type - (zəmanətli, zəmanətsiz)


Group class:

- No - (P127, S334,D101 və s.) (eyni nömrə ilə birdən çox qrup ola bilməz)
- Category - (Programming, design, system administration)
- IsOnline - Qrup online-dirmi
- Limit - Qrup online-dirsə limit 15, deyilsə 10 nəfər olmalıdır.
- Students - telebeler siyahısı, qrupda olan tələbələri ifadə edir. Qrupda tələbələrin say limiti var. Online qruplarda limit 15, offline-də isə 10-dur.
