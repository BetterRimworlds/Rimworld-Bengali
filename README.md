# RimWorld Bengali (Bengali Translation Mod)
**by [Better Rimworlds](https://github.com/BetterRimworlds)** • powered by Autonomo AI

Bring a **full Bengali localization** to RimWorld — built to be **playable, UI-safe, and consistent** across the game’s terminology.

> ✅ Designed for real gameplay: stable placeholders, consistent RimWorld vernacular, and UI-friendly strings.

---

## What you get

- **Bengali translation** for RimWorld UI + game text
- **Consistent RimWorld terminology** (custom glossary / vernacular)
- **Placeholder-safe strings** (no broken `{0}`, `[PAWN_nameDef]`, etc.)
- **UI-safe length constraints** (labels/titles kept readable where possible)

---

## Autonomous Translation Stats

```
================ BENGALI TRANSLATION ANALYSIS ================
Volume: 123,286 English words -> 121,836 Bengali words

--- LLM (ChatGPT 5.1 Equivalent) ---
Total API Calls           : 16,884
Total LLM Tokens In       : 4,187,271
Total LLM Tokens Out      : 255,443
LLM total cost            : $7.79
  ├─ Input cost           : $5.23
  └─ Output cost          : $2.55
Total runtime             : 6.82 hours

--- Human Translation Team (Dubai) ---
Project Lead Time         : 73.9 calendar days
Average Rate              : $35.00/hr

Role            | #  | Total Hrs  | Hrs/Person   | Cost                     
---------------------------------------------------------------------------
Translators     | 3  | 913.8      | 304.6        | 117,373.76 AED ($31,981.95)
Editors         | 1  | 225.4      | 225.4        | 28,952.19 AED ($7,888.88)
Proofreaders    | 1  | 79.2       | 79.2         | 10,172.39 AED ($2,771.77)
---------------------------------------------------------------------------
TOTAL BILLABLE HOURS: 1,218.4  | 156,498.34 AED ($42,642.60)

    [ VS SINGLE HUMAN ]
    Human Calendar Time   : 341.1 Days (243.7 work + 97.5 wknd)
    Autonomo Speedup      : 1200.1x FASTER

--- Human Translation Team (USA) ---
Project Lead Time         : 88.7 calendar days
Average Rate              : $75.00/hr

Role            | #  | Total Hrs  | Hrs/Person   | Cost                     
---------------------------------------------------------------------------
Translators     | 3  | 1,096.5    | 365.5        | $82,239.30               
Editors         | 1  | 270.5      | 270.5        | $20,285.69               
Proofreaders    | 1  | 95.0       | 95.0         | $7,127.41                
---------------------------------------------------------------------------
TOTAL BILLABLE HOURS: 1,462.0  | $109,652.40

    [ VS SINGLE HUMAN ]
    Human Calendar Time   : 409.4 Days (292.4 work + 117.0 wknd)
    Autonomo Speedup      : 1440.1x FASTER

===========================================================
```


## Installation

### Option A: Steam Workshop (recommended)
1. Subscribe to the mod on Steam Workshop
2. Launch RimWorld
3. Go to **Mods** → enable **RimWorld Bengali**
4. Restart RimWorld when prompted

> If you don’t see it in your list, restart Steam and RimWorld.

*(Workshop link: add once published.)*

---

### Option B: Manual install (GitHub download)
1. Download this repository as a ZIP:
   - Click **Code** → **Download ZIP**
2. Extract it
3. Copy the folder into your RimWorld Mods directory:

**Windows**
```

C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\

```

**Linux**
```

~/.steam/steam/steamapps/common/RimWorld/Mods/

```

**macOS**
```

~/Library/Application Support/Steam/steamapps/common/RimWorld/RimWorldMac.app/Mods/

```

4. Make sure the folder structure looks like:
```

RimWorld/Mods/RimWorld-Bengali/
About/
Languages/
...

```

5. Launch RimWorld → **Mods** → enable **RimWorld Bengali** → restart.

---

## Enable Bengali in RimWorld

After the mod is enabled:

1. Go to **Options**
2. Find **Language**
3. Select **Bengali**
4. Restart RimWorld if asked

---

## Load order

Typically:
- **Core**
- DLCs (if any)
- Other mods
- **RimWorld Bengali**

If another mod includes its own translation files, it may override parts of the Bengali text depending on load order.

---

## Known behavior

- Some UI strings are deliberately kept short to avoid overflow.
- Some mod-added content may remain in English unless those mods ship Bengali translations or you add patches.
- If you use many mods, translation completeness depends on whether those mods provide keyed strings / translation keys.

---

## Troubleshooting

### Bengali isn’t showing up in the language menu”
- Confirm the mod is **enabled**
- Confirm the folder path is correct:
  - `Mods/RimWorld-Bengali/Languages/Bengali/`
- Restart RimWorld after enabling the mod

### “Some text is still in English”
- That text likely comes from:
  - another mod (no Bengali translation available)
  - newly added RimWorld content that hasn’t been updated yet
- Please open an issue with:
  - a screenshot
  - the exact English text
  - your mod list + load order (if possible)

### “Text looks weird / missing characters”
- RimWorld font rendering is sensitive to:
  - font mods
  - UI scaling
- Try disabling font/UI mods to confirm compatibility.

---

## Bug reports & requests

Open a GitHub issue here:
- Include **screenshots**
- Include the **exact string** (English if possible)
- Include your **RimWorld version** and **mod list**

---

## Credits

Published by **[Better Rimworlds](https://github.com/BetterRimworlds)**
Built with the **Autonomo AI** localization pipeline (Automated QA Inspection & Copyediting).

---

## Disclaimer

RimWorld is the property of its respective owner(s).
This translation mod is an independent community project and is not affiliated with or endorsed by Ludeon Studios.

