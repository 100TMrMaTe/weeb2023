using gyak_oop;

ember el = new ember("Konyhási", "Máté");

Console.WriteLine(el.teljesnev);

ember el2 = new ember("talas", " egy idiot");

Console.WriteLine(el2.teljesnev);

udvariasember ue1 = new udvariasember("horvath" , "huni");

ue1.koszon();
ue1.koszonnev(el);
ue1.koszon(ue1);

diak d1 = new diak("talas", "miklos", 12);
diak d2 = new diak("nem", "tomjozsef ",19);

d1.koszon(ue1);
d1.koszon(d2);