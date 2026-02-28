# Pavlovska_UnityUI
Ieskaites Unity 2D projekts

## Summer Outfit Designer

Unity 2D UI ieskaites projekts.

##  Projekta mērķis

Izveidot Unity 2D lietotni, kas ļauj lietotājam izvēlēties tēlu un pielāgot tā vasaras apģērbu, izmantojot UI komponentes, C# skriptus un ainu pārvaldību.

Projekts demonstrē darbu ar interaktīvu UI, notikumiem (events), audio sistēmu un objektu transformācijām.


## Funkcijas

### Ainu pārvaldība
- [x] StartScene
- [x] DressUpScene
- [x] Pāreja no Start uz DressUp
- [x] Atgriešanās uz Start no DressUp
- [x] Exit poga (aizver programmu)

### Tēla izvēle un apģērbs
- [x] Dropdown – Girl / Boy izvēle
- [x] Dinamiski aktivizējas izvēlētais tēls
- [x] Drag & Drop apģērba uzvilkšana
- [x] Apģērba kategoriju filtrēšana ar Toggle
- [x] WardrobeManager loģika

### Izmēru maiņa
- [x] HeightSlider – maina Y (augstumu)
- [x] WidthSlider – maina X (platumu)
- [x] transform.localScale izmantošana

### Description Panel
- [x] Scroll View
- [x] Dinamisks tēla apraksts
- [x] Savienojums ar CharacterSelector

### Audio sistēma
- [x] Fona mūzika (loop)
- [x] Pogu klikšķu skaņa
- [x] Tēla skaņas efekts (pop)
- [x] Atsevišķi AudioSource mūzikai un efektiem



## ▶ Kā palaist projektu

### Unity versija
Unity 6.3LTS (6000.3.4f1)

### Soļi:
## ▶ Kā palaist projektu

### Unity versija
Unity 6.x LTS (6000.x)

### Soļi:
1. Atvērt projektu Unity vidē.
2. Atvērt StartScene (Scenes mapē).
3. Spiest ▶ Play (Unity augšējā joslā).
4. Start ainā nospiest pogu **START**, lai pārietu uz DressUpScene.
5. DressUp ainā ievadīt:
   - Vārdu,
   - Dzimšanas gadu.
6. Nospiežot pogu(SPIED PARĀDĪT), tiek parādīts teksts:
   “Supervaronis X ir Y gadus vecs!”
7. DressUp ainā iespējams:
   - izvēlēties tēlu (Girl / Boy),
   - mainīt apģērbu ar Drag & Drop,
   - filtrēt kategorijas ar Toggle,
   - mainīt izmēru ar Slider,
   - apskatīt dinamisku tēla aprakstu Scroll View panelī,
   - atgriezties uz Start ar Exit pogu.
8. Exit poga aizver programmu (Build versijā).


## Eksports

Projekts paredzēts eksportam uz:
- Windows (.exe)
- WebGL

Eksporta soļi:
1. File → Build Settings
2. Izvēlēties platformu
3. Build


## Kontroles

| Darbība     | Funkcija |
|-------------|-----------|
| Start poga  | Pāriet uz DressUpScene |
| Exit poga   | Aizver programmu |
| Dropdown    | Izvēlas Girl / Boy |
| Toggle      | Filtrē apģērba kategorijas |
| Drag & Drop | Uzvelk apģērbu |
| Sliders     | Maina tēla izmēru |
| Scroll View | Parāda tēla aprakstu |



## Ekrānšāviņi

### Start Scene
![Start Scene](start_scene.png)

### DressUp Scene
![DressUp Scene](dress_scene1.png)



## Autors

Sabine Pavlovska  
2026