using DesafioPOO.Models;

	Nokia nokia = new Nokia("111111111", "Nokia A90", "8987676767666556", 16);
	
	nokia.Ligar();
	nokia.ReceberLigacao();
	nokia.InstalarAplicativo("Photoshop");

	Iphone iphone = new Iphone("2222222", "Nokia A90", "898766564544766556", 16);

	iphone.Ligar();
	iphone.ReceberLigacao();
	iphone.InstalarAplicativo("Photoshop");
