void Menu()
{
    //initialisation de variable de type int "choixMenu"
    int choixMenu;
    // initialisation de la variable de type bool "isChoiceValid"
    bool isChoiceValid;
    // Assignation de 0 à "choixMenu" est false à  "isChoiceMenu"
    isChoiceValid  = false;
    choixMenu = 0;
    // Affichage du menu de chaque option avec le numero associé
    Console.WriteLine("--- Calculatrice ---\n");
    Console.WriteLine(" Que voulez-vous faire ? :");
    Console.WriteLine("1- Addition");
    Console.WriteLine("2- Soustraction");
    Console.WriteLine("3- Division");
    Console.WriteLine("4- Multiplication");
    Console.WriteLine("5- Addition de tous les entiers entre 2 valeurs");
    Console.WriteLine("6- Calcul avec la puissance");
    Console.WriteLine("0- Sortir");

    // controle de saisie avec une boucle while est comme condition (!isChoiceValid)
    while (!isChoiceValid)
    {
        //conversion en int
        isChoiceValid = Int32.TryParse(Console.ReadLine(), out choixMenu);
        if (!isChoiceValid)
        {
            //message si erreur dans la saisie
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }

    // switch avec la condition (choixMenu)
    switch (choixMenu)
    {
    // chaque "case" contient un "clear" de la console ainsi que le message vers ou il redirige et la fonction appelé
        case 1:
            Console.Clear();
            Console.WriteLine("Vous avez choisi l'addition \n");
            Addition();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Vous avez choisi la soustraction \n");
            Soustraction();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Vous avez choisi la division \n");
            ChoixDivision();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Vous avez choisi la multiplication \n");
            Multiplication();
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Vous avez choisi l'addition de tous les nombres entre deux valeurs \n");
            EntierEntreDeuxValeurs();
            break;
        case 6:
            Console.Clear();
            Console.WriteLine("Vous avez choisi le calcul avec la puissance \n");
            Puissance();
            break;
        case 0:
            // case pour sortir du witch
            Console.Clear();
            Console.WriteLine("Vous êtes déconnecté");
            break;
    }
    // sortie de la methode
    return;
};

float Addition()
{
    /*
     creation de la variable "premierNombre" et "deuxiemeNombre" et "resultat" de type float.
    "premierNombre" et "deuxiemeNombre" ont tous les deux la valeurs 0
    creation de la variable "isInputValid" de type bool avec la valeur false
     */
    float premierNombre;
    float deuxiemeNombre;
    float resultat;
    bool isInputValid;
    premierNombre = 0;
    deuxiemeNombre = 0;
    isInputValid = false;

    //message pour choisir ce qu'il faut entrer
    Console.Write("Entrer le premier nombre : ");
    //contrôle de saisie pour le premier nombre
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out premierNombre);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    // assigantion de la valeur false à "isInputValid" pour la deuxieme saisie
    isInputValid = false;
    //message pour choisir ce qu'il faut entrer
    Console.Write("Entrer le second nombre : ");
    //contrôle de saisie pour le premier nombre
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out deuxiemeNombre);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    // assignation de l'addition "premierNombre" + "deuxiemeNombre" à la variable resultat
    resultat = premierNombre + deuxiemeNombre;
    // affichage de l'opération est du résultat dans la console
    Console.WriteLine($"Le resultat de l'opération {premierNombre} + {deuxiemeNombre} est: {resultat} \n");
    // appel de la fonction Menu()
    Menu();
    //renvoie du resultat et sortie de la fonction
    return resultat;
};

float Soustraction()
{
    /*
    creation de la variable "premierNombre" et "deuxiemeNombre" et "resultat" de type float.
    "premierNombre" et "deuxiemeNombre" ont tous les deux la valeurs 0
    creation de la variable "isInputValid" de type bool avec la valeur false
    */
    float premierNombre;
    float deuxiemeNombre;
    float resultat;
    bool isInputValid;
    premierNombre = 0;
    deuxiemeNombre = 0;
    isInputValid = false;
    Console.Write("Entrer le premier nombre : ");
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out premierNombre);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    isInputValid = false;
    Console.Write("Entrer le second nombre : ");
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out deuxiemeNombre);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    resultat = premierNombre - deuxiemeNombre;
    Console.WriteLine($"Le resultat de l'opération {premierNombre} - {deuxiemeNombre} est: {resultat} \n");
    Menu();
    return resultat;
};

float Multiplication()
{
    float premierNombre;
    float deuxiemeNombre;
    float resultat;
    bool isInputValid;
    premierNombre = 0;
    deuxiemeNombre = 0;
    isInputValid = false;
    Console.Write("Entrer le premier nombre : ");
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out premierNombre);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    isInputValid = false;
    Console.Write("Entrer le second nombre : ");
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out deuxiemeNombre);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    resultat = premierNombre * deuxiemeNombre;
    Console.WriteLine($"Le resultat est: {resultat} \n");
    Console.WriteLine($"Le resultat de l'opération {premierNombre} * {deuxiemeNombre} est: {resultat} \n");
    Menu();
    return resultat;
};

float DivisionEuclidienne()
{
    float dividende;
    float diviseur;
    float quotient;
    float reste;
    bool isInputValid;
    dividende = 0;
    diviseur = 0;
    isInputValid = false;
    Console.Write("Entrer le diviseur : ");
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out diviseur);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    isInputValid = false;
    Console.Write("Entrer le dividende : ");
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out dividende);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    quotient = dividende / diviseur;
    reste = dividende % diviseur;
    Console.WriteLine($"Le resultat de l'opération {dividende} / {diviseur} est: {quotient} avec un reste de {reste} \n");
    Menu();
    return quotient;
};

float DivisionDecimal()
{
    float dividende;
    float diviseur;
    float quotient;
    bool isInputValid;
    dividende = 0;
    diviseur = 0;
    isInputValid = false;
    Console.Write("Entrer le diviseur : ");
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out diviseur);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    isInputValid = false;
    Console.Write("Entrer le dividende : ");
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out dividende);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    quotient = dividende / diviseur;
    Console.WriteLine($"Le resultat de l'opération {dividende} / {diviseur} est: {quotient} \n");
    Menu();
    return quotient;
};


int EntierEntreDeuxValeurs()
{
    int valeurDeDepart;
    int valeurArrive;
    int resultat;
    bool isInputValid;
    isInputValid = false;
    valeurDeDepart = 0;
    valeurArrive = 10;
    resultat = 0;
    Console.Write("Entrer la valeur de départ : ");
    while (!isInputValid)
    {
        isInputValid = Int32.TryParse(Console.ReadLine(), out valeurDeDepart);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    isInputValid = false;
    Console.Write("Entrer la valeur d'arrivé : ");
    while (!isInputValid)
    {
        isInputValid = Int32.TryParse(Console.ReadLine(), out valeurArrive);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }

    if (valeurDeDepart < valeurArrive)
    {
        for (int i = valeurDeDepart; i < valeurArrive; i++)
        {
            resultat += i;
        }
        Console.Write($"si on calcule les entiers entre {valeurDeDepart} {valeurArrive}, ");
    }
    else if (valeurDeDepart > valeurArrive)
    {
        for (int i = valeurArrive; i < valeurDeDepart; i++)
        {
            resultat += i;
            { }
        }
        Console.Write($"si on calcule les entiers entre {valeurArrive} {valeurDeDepart}, ");
    }
    Console.Write($"la somme est de {resultat} \n");
    Menu();
    return resultat;
};

double Puissance()
{
    float nombreCalculer;
    float puissance;
    double resultat;
    bool isInputValid;
    isInputValid = false;
    nombreCalculer = 0;
    puissance = 0;

    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out nombreCalculer);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    isInputValid = false;
    while (!isInputValid)
    {
        isInputValid = float.TryParse(Console.ReadLine(), out puissance);
        if (!isInputValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }
    resultat = Math.Pow(nombreCalculer, puissance);
    Console.WriteLine($"Lorsqu'on met {nombreCalculer} à la puissance {puissance} est égal à {resultat}");
    Menu();
    return resultat;
};
void ChoixDivision()
{
    int ChoixDivision;
    bool isChoiceValid;
    isChoiceValid = false;
    ChoixDivision = 3;

    Console.WriteLine("Quelle division souhaitez-vous réaliser ?");
    Console.WriteLine("1-- Division Euclidienne");
    Console.WriteLine("2-- Division Décimal");
    Console.WriteLine("3-- Revenir en arrière");


    while (!isChoiceValid)
    {
        isChoiceValid = Int32.TryParse(Console.ReadLine(), out ChoixDivision);
        if (!isChoiceValid)
        {
            Console.WriteLine("Erreur lors de la saisie, recommencé");
        }
    }

    switch (ChoixDivision)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Vous avez choisi la division Euclidienne");
            DivisionEuclidienne();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Vous avez choisi la division Décimal");
            DivisionDecimal();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Vous êtes retourné sur le menu \n");
            Menu();
            break;
    }
    return;
};


//appel de la fonction Menu()
Menu();
