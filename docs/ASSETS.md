# Pizzaer — Free Assets

License words:
- **CC0** (public domain) — free to use for anything. No credit needed (but we credit anyway — it's nice).
- **Unity Companion License** — free to use in Unity projects.
- **Unity Asset Store EULA** (Standard license) — free to use in your game, but you may **not share the raw files publicly**. ⚠️ A public GitHub repo counts as sharing. Use these packs only if the repo is private.

**Our choice:** almost everything comes from **Kenney** (CC0). All Kenney packs share one style, so the town, food, cars, and people match. They also work in a public repo with no license problem.

**Rules:**
- Import **only the files you use** (not the whole zip). Keep each FBX together with its `Textures` folder.
- Put models in `Assets/_Pizzaer/Models/<PackName>/`, sprites in `Art/UI/`, and audio in `Audio/`.
- Every asset you add gets a line in the **Used assets log** at the bottom of this file.

---

## 1. Player character and controls

| Asset | Use | Link | License | Notes |
|---|---|---|---|---|
| **Starter Assets: Character Controllers \| URP** (Unity) | Third-person player: walk, run, jump, camera | https://assetstore.unity.com/packages/slug/267961 | Unity Companion License | Made for Unity 6 LTS and URP. Needs Cinemachine + Input System (installed automatically). Use the **Third Person** part. Owner: Viset (C1). |
| Starter Assets – Third Person (older, single pack) | Backup if the URP pack has problems | https://assetstore.unity.com/packages/slug/196526 | Unity Companion License | May need URP material conversion. |

**How to get Asset Store packs:** open the link → **Add to My Assets** → in Unity: **Window → Package Management → Package Manager → My Assets** → find the pack → **Download → Import**.

## 2. Town (roads, buildings, park)

| Asset | Use | Link | License | Notes |
|---|---|---|---|---|
| **Kenney City Kit (Roads)** | Roads, crossings, street lights, fences | https://kenney.nl/assets/city-kit-roads | CC0 | Main road pieces. Check for a roundabout piece. If there isn't one, make the roundabout from a round grass platform with road pieces around it. |
| **Kenney City Kit (Suburban)** | The 5 delivery houses + fences, trees, driveways | https://kenney.nl/assets/city-kit-suburban | CC0 | Made to fit City Kit (Roads). |
| **Kenney City Kit (Commercial)** | Shops and bigger buildings; the pizza shop | https://kenney.nl/assets/city-kit-commercial | CC0 | Turn one shop into the pizza shop with a sign + a pizza model on top. |
| **Kenney Nature Kit** | Park: trees, plants, rocks, fences | https://opengameart.org/content/nature-kit | CC0 | |
| SimplePoly City – Low Poly Assets (backup) | Ready-made city, even includes a pizza shop | https://assetstore.unity.com/packages/3d/environments/simplepoly-city-low-poly-assets-58899 | Asset Store EULA ⚠️ | Free, but **only if the repo is private**. Old pack (Unity 5) → run the Render Pipeline Converter for pink materials. |

## 3. Pizza, cars, and people

| Asset | Use | Link | License | Notes |
|---|---|---|---|---|
| **Kenney Food Kit** | Pizza, pizza box, and food props for the shop | https://kenney.nl/assets/food-kit | CC0 | 200 files; pick the pizza models only. |
| **Kenney Car Kit** | Parked cars for decoration (not drivable in M1) | https://kenney.nl/assets/car-kit | CC0 | Good if we add a scooter or car in a later milestone. |
| **Kenney Mini Characters** | Customers standing at houses (C7, nice-to-have) | https://kenney.nl/assets/mini-characters | CC0 | Animated, including idle. |

## 4. UI

| Asset | Use | Link | License | Notes |
|---|---|---|---|---|
| **Kenney UI Pack** | Panels, buttons, icons for HUD, dialogue, win, menu | https://kenney.nl/assets/ui-pack | CC0 | 400+ sprites in 5 colors. Set Texture Type = **Sprite (2D and UI)**. |
| Kenney UI Pack – Adventure | Warmer, "RPG" style panels (optional) | https://kenney.nl/assets/ui-pack-adventure | CC0 | Nice for the dialogue box. |
| Font: LiberationSans SDF | All text | Comes with TextMeshPro (TMP Essentials) | Free (included) | Use this first. Change the font only if there's time. |

## 5. Sound effects

| Asset | Use | Link | License | Notes |
|---|---|---|---|---|
| **Kenney Interface Sounds** | Button clicks, confirm, error ("wrong house") | https://kenney.nl/assets/interface-sounds | CC0 | 100 OGG files |
| **Kenney RPG Audio** | Coin sound (deliver + money), footsteps, door | https://kenney.nl/assets/rpg-audio | CC0 | 50 OGG files |
| **Kenney Music Jingles** | Short win jingle | https://kenney.nl/assets/music-jingles | CC0 | 85 short jingles |

Suggested picks (Soth checks them by ear):
`SFX_Pickup` (interface confirm) · `SFX_Deliver` (coins) · `SFX_Wrong` (interface error) · `SFX_Win` (jingle) · `SFX_Click` (interface click)

## 6. Music

| Asset | Use | Link | License | Notes |
|---|---|---|---|---|
| **Two Simple Game Music Loops** (qubodup) | `MUS_Menu` (menu loop) + `MUS_Town` (level loop) | https://opengameart.org/node/174263 | CC0 | One menu tune and one in-game tune — perfect fit. Use the OGG files. |
| Happy Clappy Loop (OwlishMedia) | Backup town music (cheerful piano) | https://opengameart.org/content/happy-clappy-loop | CC0 | WAV file — convert to OGG or set compression in Unity. |

---

## How to import a Kenney pack into Unity

1. Download the zip from the link (click "Continue without donating" if you can't donate).
2. Unzip it on your computer (**not** inside the Unity project).
3. Find the **FBX** folder (Kenney packs have `Models/FBX format/`).
4. Copy the models you need **and** the `Textures` folder (usually `colormap.png`) into `Assets/_Pizzaer/Models/<PackName>/`.
5. Click a model → **Inspector → Model tab** → check the **Scale Factor**. Tick **Generate Colliders** for buildings and roads → **Apply**.
6. Drag it into your Sandbox scene. Pink? → **Window → Rendering → Render Pipeline Converter → Material Upgrade**.

---

## Used assets log (fill this in as you import)

| Asset pack | Files used | Where in project | License | Added by | Date |
|---|---|---|---|---|---|
| *example:* Kenney City Kit (Roads) | road-straight, road-crossroad, road-bend… | `_Pizzaer/Models/CityRoads/` | CC0 | Dina | Nov 4 |
| | | | | | |

## Credits (copy into README and the game)

```
Pizzaer — made by Dina, Viset, Panha, Soth
3D models, UI and sounds: Kenney (www.kenney.nl) — CC0
Music: "Two Simple Game Music Loops" by qubodup (OpenGameArt) — CC0
Player controller: Unity Starter Assets — Unity Companion License
```
