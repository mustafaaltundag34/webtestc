Feature: Login

A short summary of the feature

Scenario: LoginSenaryosu
	* "http://eaapp.somee.com/" Chrome Internet sayfasini Acarsam
	* "2" saniye beklerim
	* "//*[@id="loginLink"]" xpath adresli "Login" Butonuna tıklarım
	* Kullanici Adi ve Sifresini girersem
	| UserName | Password |
	| admin    | password |
	* Login butonuna tiklarsam
	* "2" saniye beklerim
	* "//*[@id="logoutForm"]/ul/li[2]/a" xpath adresli "Logoff" Elementini kesinlikle gorurum
	* "2" saniye beklerim
	* "/html/body/div[1]/div/div[2]/ul/li[3]/a" xpath adresli "Employee List" Butonuna tıklarım
	* "2" saniye beklerim
	* "/html/body/div[2]/form/input[1]" xpath adresli input alanina "saranya" değerini yazarim
	* "2" saniye beklerim
	* "/html/body/div[2]/form/input[2]" xpath adresli "Search" Butonuna tıklarım
	* "5" saniye beklerim
	* "//*[@id="logoutForm"]/ul/li[2]/a" xpath adresli "Logoff" Butonuna tıklarım
	* "5" saniye beklerim
	* Oturumu Kapatirim


	

	Scenario: LoginSenaryosuyanlissifre
	* "http://eaapp.somee.com/" Chrome Internet sayfasini Acarsam
	* "2" saniye beklerim
	* "//*[@id="loginLink"]" xpath adresli "Login" Butonuna tıklarım
	* Kullanici Adi ve Sifresini girersem
	| UserName | Password |
	| admin    | password1 |
	* Login butonuna tiklarsam
	* "2" saniye beklerim
	* "//*[@id="logoutForm"]/ul/li[2]/a" xpath adresli "Logoff" Elementini kesinlikle gorurum
	* "2" saniye beklerim
	* "/html/body/div[1]/div/div[2]/ul/li[3]/a" xpath adresli "Employee List" Butonuna tıklarım
	* "2" saniye beklerim
	* "/html/body/div[2]/form/input[1]" xpath adresli input alanina "saranya" değerini yazarim
	* "2" saniye beklerim
	* "/html/body/div[2]/form/input[2]" xpath adresli "Search" Butonuna tıklarım
	* "5" saniye beklerim
	* "//*[@id="logoutForm"]/ul/li[2]/a" xpath adresli "Logoff" Butonuna tıklarım
	* "5" saniye beklerim
	* Oturumu Kapatirim