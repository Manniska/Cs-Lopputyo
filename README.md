# Mineral LootBox Simulator

Mineral LootBox Simulator on C#-kielellä toteutettu Windows Forms -työpöytäsovellus. Projekti on toteutettu kurssin lopputyönä, ja se demonstroi olio-ohjelmoinnin periaatteita, tapahtumapohjaista käyttöliittymäsuunnittelua, tietorakenteiden hallintaa sekä tiedostopohjaista tiedon pysyvyyttä (File I/O).

---

## 1. Sovelluksen toiminta ja käyttötarkoitus

Sovelluksen ideana on simuloida laatikonavausmekaniikkaa (loot box) ja tavaroiden inventaariohallintaa. Pelaaja kerää mineraaleja, jalokiviä ja kivilajeja avaamalla erihintaisia laatikoita ja ansaitsee lisää varoja myymällä keräämiään esineitä.

### Päätoiminnot:
- **Laatikoiden avaaminen:** Pelaaja voi avata kolmea eri tasoista laatikkoa:
  - **Free Box (0 kolikkoa):** Ilmainen peruslaatikko, josta saa pääasiassa tavallisia kiviä ja malmeja, mutta myös pienen onnenkantamoisen harvinaisiin löytöihin.
  - **Common Box (20 kolikkoa):** Keskitason laatikko, jossa on parempi todennäköisyys Uncommon- ja Rare-tason jalokiviin.
  - **Rare Box (50 kolikkoa):** Huipputason laatikko ilman roskasaalista, josta voi saada erittäin arvokkaita Epic- ja Legendary-mineraaleja (arvo jopa 2500 kolikkoa).
- **Inventaario ja kaupankäynti:**
  - Kaikki avatut esineet siirtyvät pelaajan reppuun.
  - Inventaariossa näkyy koko repun arvo sekä valitun esineen myyntihinta.
  - Pelaaja voi myydä yksittäisen valitun esineen (`Sell Selected`) tai tyhjentää koko repun rahaksi yhdellä painalluksella (`Sell All`).
- **Automaattinen tallennus:** Pelaajan saldo ja kerätyt esineet tallennetaan automaattisesti tekstitiedostoon (`savegame.txt`) aina laatikon avaamisen, esineiden myynnin tai ohjelman sulkemisen yhteydessä. Tiedot ladataan takaisin peliin käynnistyksen yhteydessä.

---

## 2. Vuokaavio sovelluksesta

