create function kdvli(birim_fiyat float)
returns float
language plpgsql
as
$$
begin
birim_fiyat=birim_fiyat*0.8+birim_fiyat;
return birim_fiyat;
end;
$$;

create function stoktoplam()
returns integer
language plpgsql
as
$$
declare 
toplam integer;
begin
toplam:=(select sum("stok_miktar")from"urun");
return toplam;
end;
$$;








create urungetir(prmt varchar)
returns table
(
 idsutun int;
 urunadsutun varchar;
)
as 
$$
begin
return query
select 
urun_id,
urun_ad
from urun
where urun_ad like prmt;
end;
$$
language plpgsql;




CREATE FUNCTION urunnbul(urunid integer)
 RETURNS TABLE(id integer, adi character varying)
 LANGUAGE plpgsql
   AS $$
BEGIN
RETURN QUERY SELECT "urun_id", "urun_ad" FROM urun
   WHERE "urun_id" = urunid;
END;
 $$;
create or replace function eklenenurun()
 returns trigger
 as
$$
  begin
insert into eklenen_urun(urun_id_e,urun_ad_e,personel_e,magaza_e,kategori_e)
 values(new.urun_id,new.urun_ad,new.personel,new.magaza,new.kategori);
  return new;
  end;
  $$
 language plpgsql;

 create trigger eklenenuruntrig
after insert 
 on urun
 for each row
 execute procedure eklenenurun();




create or replace function toplamurun()
 returns trigger
as
 $$
begin
update toplam_urun set sayi=sayi+1;
 return new;
end;
 $$
language plpgsql;


create trigger toplamuruntrig
 	after insert
  	on urun
 	for each row
 execute procedure toplamurun();





 create or replace function toplamurun2()
 returns trigger
 as
 $$
 begin
 update toplam_urun set sayi=sayi+1;
 return new;
 end;
 $$
 language plpgsql;


 create trigger toplamurun2trig
 after delete
 on urun
 for each row
execute procedure toplamurun2();

  
  
  create or replace function silinenurun()
 returns trigger
 as
$$
  begin
insert into silinen_urun(urun_id_e,urun_ad_e,personel_e,magaza_e,kategori_e)
 values(old.urun_id,old.urun_ad,old.personel,old.magaza,old.kategori);
  return new;
  end;
  $$
 language plpgsql;

 create trigger silinenuruntrig
after delete
 on urun
 for each row
 execute procedure silinenurun();













create table bolge(
	bolge_id integer not null ,
	bolge_ad character varying,
	il_ad integer
);
create table fatura(
	fatura_id integer not null,
	fatura_tarih date
	
);
create table il(
	il_id integer not null,
	il_ad character varying	
);
create table ilce(
	ilce_id integer not null,
	ilce_ad character varying,
	il integer
);
create table iletisimBilgileri(
	iletisim_id integer not null,
	telefon character varying,
	ilce integer,
	insan_id integer
);








create table insan (
    insan_id integer NOT NULL,
    insan_ad character varying ,
    insan_soyad character varying ,
    insan_tel character varying ,
    insan_tur character varying 
);
create table islem(
	islem_id integer not null,
	odeme_tur character varying,
	islem_tarih date ,
	siparis_id integer not null
	
);
create table kargoFirmasi(
	firma_id integer not null,
	firma_ad character varying
);
create table kategori(
	kategori_id integer not null,
	kategori_ad character varying
);
create table magaza(
	magaza_id integer not null,
	magaza_adres character varying,
	magaza_tel character varying
);
create table musteri(
	insan_id integer not null,
	musteri_adres character varying 	
);
create table personel(
   insan_id integer not null
   magaza_id integer,
	
);
create table siparis(
	siparis_id integer not null,
	siparis_tarih date,
	siparis_tutar integer,
	siparis_durum character varying,
	musteri_id integer not null,
	fatura_id integer not null,
	kargo_firmasi integer
	
);
create table tedarik(
	insan_id integer not null,
	magaza_id integer
);

create table urun(
	urun_id integer not null,
	urun_ad character varying,
	personel integer not null,
	magaza integer not null,
	kategori integer not null,
	birim_fiyat integer,
	stok_miktar integer
);
Create table insan(
insan_id serial primary key not null,
insan_ad varchar ,
insan_soyad varchar ,
insan_tel varchar,
insan_tur varchar
);

Create table musteri(
Like insan ıncluding indexes
)inherits(insan);


Create table personel(
Like insan ıncluding indexes
)inherits(insan);





