(* 04_2_04.fsx *)

type Nokta = {x:int;y:int}

// YÖNTEM-1 : Kaydı parçalama ve alan sökme yöntemi
let xEksenindeKaydır dx nokta =
    // Kaydı parçala ve tüm alan değerlerini sök
    let {x=kx;y=ky} = nokta 

    // Güncel değerler ile yeni kayıt oluştur
    {x=kx + dx; y=ky} 

// TEST
let n1 = {x=0;y=0}
xEksenindeKaydır 1 n1


// YÖNTEM-2 : with kullanımı
let xEksenindeKaydır' dx nokta =
    // Kaydı parçala ve sadece güncellenecek alan değerlerini sök
    let {x=kx} = nokta
    
    // eski kaydı kopyala ve sadece x alanını güncelle
    {nokta with x=kx + dx; } 

// TEST
let n2 = {x=0;y=0}
xEksenindeKaydır' 1 n1
