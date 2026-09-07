# LootBox Simulator

---

## 1. Sovelluksen toiminta ja käyttötarkoitus

Pelaaja kerää mineraaleja ja jalokiviä avaamalla erihintaisia laatikoita ja ansaitsee lisää saldoa myymällä keräämiään esineitä.

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
<img width="1002" height="603" alt="Näyttökuva 2026-09-07 093359" src="https://github.com/user-attachments/assets/b48c347d-ad47-4b29-b3be-4647fef48df6" />
<img width="1002" height="602" alt="Näyttökuva 2026-09-07 093426" src="https://github.com/user-attachments/assets/57cd15b0-345b-49c3-9bbf-d8e7b160dcca" />
<img width="1004" height="604" alt="Näyttökuva 2026-09-07 093450" src="https://github.com/user-attachments/assets/32ef8982-463f-4bbd-8345-545d13d92570" />
<img width="1003" height="601" alt="Näyttökuva 2026-09-07 093505" src="https://github.com/user-attachments/assets/e734f94a-8541-408c-a29e-7d448c20ba91" />
<img width="1002" height="603" alt="Näyttökuva 2026-09-07 093517" src="https://github.com/user-attachments/assets/3e1332f3-de6e-4c22-8f0c-f109536ed1de" />

---

## 2. Vuokaavio sovelluksesta
<img width="3020" height="2260" alt="vuokaavio" src="https://github.com/user-attachments/assets/245d5ae0-b93b-4974-a3ae-f394e17b23ad" />


---

## 3. Jatkokehitysideat

- Tehdä esineiden stacking systeemi eli esineet pinoutuvat.
- Tehdä graafiset näkymät.
