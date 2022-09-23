
/*
    Insan
    ad soyad tckimlikNo 
    
    Ögrenci
    okulno
    egitimSeviyesi
    okulAdi
    func Oku()

    Calisan
    calistiğiSirket
    calismaYılı
    
    Egitmen
    brans
    func DersAnlat()

    ilkOkulOgrencisi   

*/


class Insan {
    constructor(ad, soyad, kimlik){
        this.ad = ad;
        this.soyad = soyad;
        this.kimlik = kimlik;
    }

    yemekYe(){
        console.log(`${this.ad} ${this.soyad} yemek yedi`);
    }

    suIc(){
        console.log('su iç')
    }
}

var insan = new Insan('Gizem','İşeri','1234566788764');
console.log(insan);


class Ogrenci extends Insan{    
    constructor(ad, soyad, kimlik, okulNo, egitimSeviyesi, okulAdi){
        super(ad,soyad,kimlik);
        this.okulNo=okulNo;
        this.egitimSeviyesi=egitimSeviyesi;
        this.okulAdi = okulAdi;
    }

    Oku(){
        console.log(`${this.ad} ${this.soyad} ${this.okulAdi} Okulunda okuyor`);
    }
}

var ogrenci = new Ogrenci('Kaan','Lokum','12345454656','1','lisans','Hecettepe');
console.log(ogrenci);


class IlkOkulOgrencisi extends Ogrenci{    
    constructor(ad, soyad, kimlik, okulNo, okulAdi){   
        super(ad,soyad,kimlik,okulNo,'ilkokul',okulAdi);
    }
}

var ilkOkulOgrencisi = new IlkOkulOgrencisi("aaa",'bbb','cccc','3234','a ilkokulu');
console.log(ilkOkulOgrencisi);



/*1)Dizinin elemanlarından baş harfi A olanlar ile yeni bir dizi oluşturan callback functionı oluşturun */

/*
benim dizinin elemanlarını dönmem lazım
dizinin her elamanının baş harfini kontrol et A mi değil mi ? A ise yeni diziye ekle
*/

const nameArray = ['Serdar','Ömer','Ahmet']

function myMap(nameArray, callback){
    const filteredArray = [];
    for (let i = 0; i < nameArray.length; i++) {
        
        let filteredItem=callback(nameArray[i]);
        filteredArray.push(filteredItem);
    }
    return filteredArray;
}

function filter(arrayItem){
    if(arrayItem[0] =='A'){
    return arrayItem;   
    }
}

var filtArray =myMap(nameArray,filter);
console.log(filtArray);


/*
 )
https://northwind.vercel.app/api/ linkindeki categories dizisini tanımlayıp bu dizinin elemanlarının name özelliklerini listeleyen callback functionu yazınız.

https://fakestoreapi.com/carts linkindeki kullanıcıların siparis kartlarının dizisini oluşturun.Bir kullanıcı tüm siparişlerinde toplamda kaç ürün aldığını veren callback functionı oluşturun.  

https://jsonplaceholder.typicode.com/todos linkindeki todos dizisini alıp kullanıcı idsine göre kaç görevi tamamladığını geri dönen callback funtionı yazın

)https://jsonplaceholder.typicode.com/posts linkindeki posts dizisini alıp kullanıcı idsine göre filtreleyen callback functionı yazın



)Dizinin her elemanının karakter sayısını bir diziye atıp geriye o diziyi dönen callback functionı yazınız

) Dizinin elemanlarından baş harfi A olanlar ile yeni bir dizi oluşturan callback functionı oluşturun

*/