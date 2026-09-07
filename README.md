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

---

## 2. Vuokaavio sovelluksesta
<img width="3020" height="2260" alt="LopputyoVuokaavio" src="https://github.com/user-attachments/assets/4a1f42ca-f092-4dcf-8651-bc4680dfd902" />

---

## 3. Jatkokehitysideat

- Tehdä esineiden stacking systeemi eli esineet pinoutuvat.
- Tehdä graafiset näkymät.
