import { Evenement } from './evenement.model';
import { Categorie } from './categorie.model';
import { Plaats } from './plaats.model';

export const EVENEMENTEN: Evenement[] = [
    {
        Id:1,
        Titel:"Muziek in de oren.",
        Categorie:Categorie.Klassiek,
        Locatie:Plaats.Aalst,
        Beschrijving:"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
        Datum: new Date('2003-08-16T00:00:00'),
        File:"Klassiek.jpg"
      },{
        Id:2,
        Titel:"Musique à là Mule",
        Categorie:Categorie.Klassiek,
        Locatie: Plaats.Antwerpen,
        Beschrijving:"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
        Datum: new Date('2002-11-16T00:00:00'),
        File:"Klassiek.jpg"
      },{
        Id:3,
        Titel:"Pop concert",
        Categorie:Categorie.Pop,
        Locatie: Plaats.Brugge,
        Beschrijving:"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
        Datum: new Date('2002-11-16T00:00:00'),
        File:"Pop.jpg"
      },
      {
        Id:4,
        Titel:"Heavy Rock and roll",
        Categorie:Categorie.RockAndMetal,
        Locatie: Plaats.Gent, 
        Beschrijving:"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
        Datum: new Date('2005-11-16T00:00:00'),
        File:"Rock.png"
      }
];
