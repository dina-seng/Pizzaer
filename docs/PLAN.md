# Pizzaer — Project Plan

- **Milestone 1:** `M1 – Playable build` · due **Tue, Nov 10, 2026**
- **Milestone 2:** `M2 – Timer & polish` · starts only after M1 is merged
- We count **finished issues**, not hours. Each issue is small (about half a day or less).
- Owners: **Dina** (level + integration + merge), **Viset** (scripts: player, zones, marker, menu, audio), **Panha** (scripts: delivery + UI logic, lead), **Soth** (UI layout, sound, writing)
- All rules for working and merging: [WORK_RULES.md](WORK_RULES.md)

| Day | Date |
|---|---|
| Day 1 | Tue, Nov 3 |
| Day 2 | Wed, Nov 4 |
| Day 3 | Thu, Nov 5 |
| Day 4 | Fri, Nov 6 |
| Day 5 | Sat, Nov 7 — **feature freeze in the evening** |
| Day 6 | Sun, Nov 8 — bug fixing |
| Day 7 | Mon, Nov 9 — final build |
| Submit | **Tue, Nov 10** |

---

## Daily plan

| Day | Goal of the day | Dina | Viset | Panha | Soth |
|---|---|---|---|---|---|
| **1** | Everyone can open the project, branch, and make a PR | A1, A4, start B1 | A3, start C1 | A2, A5, A3 | A3, start E1 |
| **2** | Each piece works **alone** | B1, B2 | C1, C2 | D1 | E1, E2 |
| **3** | Interaction works **in sandboxes** | B3, B4 | C3, C4 | D2 | E3 |
| **4** | 🎯 **First integration: the full loop playable in Town** (ugly is OK) | B5 | C5 | D3 | E4, E5 |
| **5** | Sound, real text, polish → **Playtest #1** → **feature freeze** | B6 | C6, C7 (nice) | D4, D5 | E6 |
| **6** | Fix bugs only | G2 | G2 | G2 | G2 |
| **7** | Final build + README + demo | G3 | G4 help | G4 | G4 help |

**Every day:**
- Morning: pull `main` → stand-up (10 minutes) → move your cards
- Evening: push your branch → open a PR → **Dina merges before 9 PM** → everyone pulls `main`

**Most important day = Day 4.** If the loop is not playable on Day 4 evening, Panha cuts nice-to-haves immediately.

---

## Board columns

`Backlog` → `Todo (this day)` → `In Progress` → `In Review` → `Done`

## Labels

`epic` · `setup` · `town` · `player` · `delivery` · `ui` · `audio` · `writing` · `test` · `bug` · `nice-to-have` · `M2` · `blocked`

---

## Epics and issues — Milestone 1

Each epic is a parent issue. Each issue below is a **sub-issue** of its epic.
IDs like `A1` are for this document. GitHub gives its own numbers (`#12`). Put the ID at the start of the title, for example `A1 · Fix Git LFS…`.

### 🟦 Epic A — Project setup  `epic` `setup`

#### A1 · Fix Git LFS, clean the template, create folders and scenes
- **Owner:** Dina · **Day:** 1 · **Labels:** `setup`
- **Description:** Turn Git LFS on (the first commit missed it). Delete template files. Create our folder structure, the `Zone` tag, and empty `MainMenu` and `Town` scenes. Add both to Build Profiles.
- **Acceptance criteria:**
  - [ ] `git lfs install` done; `.gitattributes` unchanged; new PNG/FBX files show "Stored with Git LFS" on GitHub
  - [ ] `Assets/TutorialInfo/`, `Assets/Readme.asset`, and `Assets/Scenes/SampleScene.unity` deleted (inside Unity)
  - [ ] All folders from ARCHITECTURE.md §2 exist (each with an empty `.gitkeep` file so Git keeps it)
  - [ ] Tag `Zone` added
  - [ ] OS junk lines (`.DS_Store`, `Thumbs.db`, `desktop.ini`) added to `.gitignore` (GITHUB_GUIDE.md Step 3b)
  - [ ] `MainMenu.unity` and `Town.unity` exist; Build Profiles scene list = `0 MainMenu`, `1 Town`
  - [ ] Project opens with 0 errors after a fresh clone

#### A2 · Create the GitHub board, labels, milestones, epics, and issues
- **Owner:** Panha · **Day:** 1 · **Labels:** `setup`
- **Description:** Follow GITHUB_GUIDE.md steps 5–8. Create every issue in this file and assign the owners.
- **Acceptance criteria:**
  - [ ] Milestones M1 (due Nov 10) and M2 exist
  - [ ] All labels exist
  - [ ] Project board with 5 columns and a "Day" field
  - [ ] Every issue in this file exists with owner, milestone, labels, day, and parent epic

#### A3 · Team onboarding (each person does this)
- **Owner:** Everyone (Dina, Viset, Panha, Soth) · **Day:** 1 · **Labels:** `setup`
- **Description:** Follow [QUICK_START.md](QUICK_START.md) parts A and B: install Unity 6000.3.8f1, Git, Git LFS, and GitHub Desktop, clone the repo, open the project, create your Sandbox scene, and open your first PR. Start **after** Dina's A1 is merged.
- **Acceptance criteria:**
  - [ ] Unity version is exactly **6000.3.8f1** on all 4 computers
  - [ ] `git lfs install` run once on each computer
  - [ ] Each person merged a PR that adds `Scenes/Sandbox/Sandbox_<Name>.unity` (plane + light + camera)
  - [ ] Each person read OVERVIEW.md, ARCHITECTURE.md, and WORK_RULES.md

#### A4 · Protect `main` and add the PR template
- **Owner:** Dina · **Day:** 1 · **Labels:** `setup`
- **Description:** Follow GITHUB_GUIDE.md step 4. Commit `.github/pull_request_template.md` and the `docs/` folder.
- **Acceptance criteria:**
  - [ ] Nobody can push directly to `main`; PRs need 1 approval
  - [ ] Opening a new PR shows the template with checklists

#### A5 · Script stubs (empty scripts with the agreed method names)
- **Owner:** Panha · **Day:** 1 · **Labels:** `setup` `delivery`
- **Description:** Create all 7 scripts from ARCHITECTURE.md §4 with **only** the class, fields, and public methods (empty bodies). This way, everyone's code compiles from Day 2, even if other parts are not ready.
- **Acceptance criteria:**
  - [ ] `DeliveryOrder`, `DeliveryManager`, `InteractZone` (+ `ZoneType`), `TargetMarker`, `UIManager`, `MainMenu`, `AudioManager` exist in the correct folders
  - [ ] Public method names exactly match ARCHITECTURE.md
  - [ ] 0 compile errors
  - [ ] After merge, each script belongs to its owner (ARCHITECTURE.md §4)

### 🟩 Epic B — Town map  `epic` `town`

#### B1 · Import the 3D model packs
- **Owner:** Dina · **Day:** 1–2 · **Labels:** `town`
- **Description:** Import only the models we need from ASSETS.md (Kenney City Kits, Food Kit, Car Kit, Mini Characters) into `_Pizzaer/Models/`.
- **Acceptance criteria:**
  - [ ] FBX files + their Textures folder are in `_Pizzaer/Models/<Pack>/`
  - [ ] No pink materials; Generate Colliders is ticked on buildings and roads
  - [ ] Scale checked next to a 1.8 m capsule (doors fit the player)
  - [ ] Every pack is listed in ASSETS.md

#### B2 · Town layout (block-out)
- **Owner:** Dina · **Day:** 2 · **Labels:** `town`
- **Description:** Build the map in `Town.unity`: roads, a roundabout, a park, about 10 filler buildings, a spot for the pizza shop, and 5 house spots spread around.
- **Acceptance criteria:**
  - [ ] Walking from the shop to the farthest house takes 60 seconds or less
  - [ ] Roundabout and park are visible
  - [ ] Hierarchy follows ARCHITECTURE.md §1
  - [ ] Top-view screenshot in the PR

#### B3 · Shop and house prefabs with signs
- **Owner:** Dina · **Day:** 3 · **Labels:** `town`
- **Description:** Make `Env_PizzaShop` and `Env_House_01`–`05` with big signs ("PIZZA", "1"–"5"). Add an empty child named `ZoneSpot` at each door (the zones come from C3).
- **Acceptance criteria:**
  - [ ] 6 prefabs in `Prefabs/Environment/`, pivot at the bottom center
  - [ ] Signs are readable from 10 m away
  - [ ] Placed in Town

#### B4 · Colliders and map borders
- **Owner:** Dina · **Day:** 3 · **Labels:** `town`
- **Description:** Make sure the player can't walk through anything or leave the map.
- **Acceptance criteria:**
  - [ ] Can't walk through buildings, cars, or trees
  - [ ] Invisible walls around the map (`MapBorders`); 1 minute of running along all edges with no escape
  - [ ] No spots where the player gets stuck

#### B5 · 🎯 First integration: put all gameplay prefabs into Town
- **Owner:** Dina · **Day:** 4 · **Labels:** `town` `test`
- **Description:** Add `Player_Pizzaer`, `Core_GameManager`, `Marker_Target`, and `UI_Canvas`. Put `Zone_Shop` and `Zone_House` into the shop and house prefabs, and set `houseNumber` 1–5.
- **Depends on:** C2, C3, C4, D2, E4
- **Acceptance criteria:**
  - [ ] The full loop works in Town: shop → house → money → … → 5 deliveries → Win panel
  - [ ] Marker always points to the right place
  - [ ] 0 errors in the Console during one full play

#### B6 · Lighting, skybox, and decoration
- **Owner:** Dina · **Day:** 5 · **Labels:** `town`
- **Description:** Make the town look nice: sun direction, skybox, parked cars, trees, benches, and street signs.
- **Acceptance criteria:**
  - [ ] Town looks bright and friendly (screenshot)
  - [ ] Still about 60 FPS or more in the Game view Stats
  - [ ] All new objects have colliders where the player can touch them

### 🟨 Epic C — Player and interaction  `epic` `player`

#### C1 · Import Starter Assets – Third Person (URP)
- **Owner:** Viset · **Day:** 1–2 · **Labels:** `player` `setup`
- **Description:** Import from the Asset Store (see ASSETS.md). This also installs Cinemachine and changes `Packages/` — allowed **only in this issue**. Make this PR small and merge it first.
- **Acceptance criteria:**
  - [ ] Starter Assets imported; `Packages/manifest.json` change is in this PR
  - [ ] In `Sandbox_Viset`: walk, run, jump, and camera work
  - [ ] 0 errors; no pink materials

#### C2 · `Player_Pizzaer` prefab
- **Owner:** Viset · **Day:** 2 · **Labels:** `player`
- **Description:** Make a Prefab Variant of the Starter Assets player (with MainCamera + PlayerFollowCamera) in `Prefabs/Player/`. Remove mobile joystick UI if present.
- **Acceptance criteria:**
  - [ ] Root tagged **Player**
  - [ ] Walk speed feels good for a small town (start: Move 3, Sprint 6)
  - [ ] Dropping the prefab into an empty scene with a plane works right away

#### C3 · `InteractZone` script + `Zone_Shop` / `Zone_House` prefabs
- **Owner:** Viset · **Day:** 3 · **Labels:** `player` `delivery`
- **Description:** Fill in `InteractZone.cs` (starter code in ARCHITECTURE.md §8). Make the 2 zone prefabs.
- **Acceptance criteria:**
  - [ ] Zones: BoxCollider about 3×2×3, Is Trigger ✔, tag `Zone`
  - [ ] Enter → `DeliveryManager.PlayerEntered` called; Exit → `PlayerLeft`; E inside → `Interact`
  - [ ] Works in Sandbox with test cubes (GIF)
  - [ ] Hook-up notes for Dina in the PR

#### C4 · `TargetMarker` script + `Marker_Target` prefab
- **Owner:** Viset · **Day:** 3 · **Labels:** `player`
- **Description:** A glowing, spinning pillar or arrow above the next target. Material `M_MarkerGlow` (emission on).
- **Acceptance criteria:**
  - [ ] `MoveTo(target)` and `Hide()` work
  - [ ] Visible from far away in daylight
  - [ ] No collider on the marker

#### C5 · `MainMenu` script
- **Owner:** Viset · **Day:** 4 · **Labels:** `ui`
- **Description:** Fill in `MainMenu.cs` (starter code). Write hook-up notes for Soth.
- **Acceptance criteria:**
  - [ ] Play → story panel; Start → loads Town; Quit works in a build
  - [ ] The cursor is visible and unlocked in the menu

#### C6 · `AudioManager` script
- **Owner:** Viset · **Day:** 5 · **Labels:** `audio`
- **Description:** Fill in `AudioManager.cs` (starter code). Write hook-up notes for Soth.
- **Acceptance criteria:**
  - [ ] `AudioManager.Instance.Play(clip)` plays a sound once
  - [ ] Nothing breaks if a clip is empty

#### C7 · Customer NPCs at the houses  `nice-to-have`
- **Owner:** Viset · **Day:** 5 · **Labels:** `player` `nice-to-have`
- **Description:** `NPC_Customer` prefab from Kenney Mini Characters with an idle animation. Dina places one next to each house.
- **Acceptance criteria:**
  - [ ] Idle animation plays; NPC has a collider; pivot at the feet

### 🟧 Epic D — Delivery system  `epic` `delivery`

#### D1 · `DeliveryOrder` + `DeliveryManager` logic
- **Owner:** Panha · **Day:** 2 · **Labels:** `delivery`
- **Description:** Fill in both scripts (starter code). Make the `Core_GameManager` prefab. Until the UI is ready, `UIManager` stub methods can use `Debug.Log`.
- **Acceptance criteria:**
  - [ ] Shop → "has pizza" → right house → money + next order; wrong house → message; 2nd shop visit with a pizza → "You already have a pizza"
  - [ ] Clear `Debug.LogError` if the shop or a house is missing
  - [ ] Tested in `Sandbox_Panha` with 2 cube zones (Console screenshot)

#### D2 · `UIManager` script
- **Owner:** Panha · **Day:** 3 · **Labels:** `delivery` `ui`
- **Description:** Fill in `UIManager.cs` (starter code). Write hook-up notes for Soth using the object names in WORK_RULES.md §2.3.
- **Acceptance criteria:**
  - [ ] `SetMoney`, `SetOrder`, `ShowPrompt`, `ShowDialogue` (auto-hide after 3 s), `ShowWin`, `PlayAgain`, `BackToMenu` work
  - [ ] Tested with Soth's `UI_Canvas` in `Sandbox_Panha`

#### D3 · Win flow
- **Owner:** Panha · **Day:** 4 · **Labels:** `delivery`
- **Description:** After the 5th delivery: hide the marker, show the Win panel, unlock the cursor, freeze the game. Play Again and Menu buttons work.
- **Acceptance criteria:**
  - [ ] Win panel shows the correct total money
  - [ ] Play Again restarts Town with money = 0; Menu goes to MainMenu
  - [ ] Game is not frozen after restart (`Time.timeScale` = 1)

#### D4 · Fill in the 5 real orders
- **Owner:** Panha · **Day:** 5 · **Labels:** `delivery` `writing`
- **Description:** Copy the 5 orders from `docs/STORY.md` into `Core_GameManager`.
- **Acceptance criteria:**
  - [ ] 5 orders with house number, pizza, customer name, line, and reward
  - [ ] Soth checked the text in the game

#### D5 · Hook up sounds
- **Owner:** Panha · **Day:** 5 · **Labels:** `delivery` `audio`
- **Description:** Call `AudioManager` in `DeliveryManager.Interact` for pickup, deliver, wrong, and win.
- **Acceptance criteria:**
  - [ ] Each event plays the right sound
  - [ ] Game still works if `Core_Audio` is missing (no errors)

### 🟪 Epic E — UI, story, and sound  `epic` `ui`

#### E1 · Write the story and dialogue (`docs/STORY.md`)
- **Owner:** Soth · **Day:** 1–2 · **Labels:** `writing`
- **Description:** Story intro (3–4 lines), the chef's name, and 5 orders (house, pizza, customer name, customer line, reward). Also the win text.
- **Acceptance criteria:**
  - [ ] Simple English; each dialogue line is 15 words or fewer
  - [ ] Team agreed in chat

#### E2 · `UI_Canvas` prefab — HUD
- **Owner:** Soth · **Day:** 2 · **Labels:** `ui`
- **Description:** Import Kenney UI Pack sprites. Build the HUD: MoneyText (top-left), OrderText (top-center), PromptPanel "Press E" (center-bottom).
- **Acceptance criteria:**
  - [ ] Object names exactly as in WORK_RULES.md §2.3
  - [ ] Canvas Scaler 1920×1080, Match 0.5; anchors correct at 16:9 and 16:10
  - [ ] Screenshot

#### E3 · Dialogue panel + Win panel
- **Owner:** Soth · **Day:** 3 · **Labels:** `ui`
- **Description:** Add DialoguePanel (speaker name + line, bottom of the screen) and WinPanel (title, money, 2 buttons) inside `UI_Canvas`.
- **Acceptance criteria:**
  - [ ] Long lines (15 words) fit in the box
  - [ ] Buttons have hover/pressed colors
  - [ ] Panels start inactive

#### E4 · Attach `UIManager` to `UI_Canvas`
- **Owner:** Soth · **Day:** 4 · **Labels:** `ui`
- **Description:** Follow Panha's hook-up notes from D2.
- **Acceptance criteria:**
  - [ ] All UIManager fields filled (no "None")
  - [ ] Buttons linked to `PlayAgain` and `BackToMenu`
  - [ ] Works in `Sandbox_Soth` with `Core_GameManager` and 2 cube zones

#### E5 · Main menu scene
- **Owner:** Soth · **Day:** 4 · **Labels:** `ui`
- **Description:** Build `MainMenu.unity`: TitlePanel (title "PIZZAER", Play, Quit) and StoryPanel (story text, Start). Attach `MainMenu.cs` (Viset's C5 notes).
- **Acceptance criteria:**
  - [ ] Object names as in WORK_RULES.md §2.3
  - [ ] Play → story; Start → Town
  - [ ] Looks good at 16:9 and 16:10

#### E6 · Music, sound effects, and the `Core_Audio` prefab
- **Owner:** Soth · **Day:** 5 · **Labels:** `audio`
- **Description:** Import 2 music loops (menu + town) and 5 SFX (pickup, deliver, wrong, win, click). Make `Core_Audio` and attach `AudioManager` (Viset's C6 notes). Add menu music in MainMenu.
- **Acceptance criteria:**
  - [ ] Music loops with no gap; volumes balanced
  - [ ] All files named `MUS_`/`SFX_` and listed in ASSETS.md
  - [ ] Button click sound in the menu

### 🟥 Epic G — Test and release  `epic` `test`

#### G1 · Playtest #1 (Day 5 evening)
- **Owner:** Everyone (Panha leads) · **Day:** 5 · **Labels:** `test`
- **Description:** Each person plays the full game 2 times from MainMenu. Every problem becomes a `bug` issue with steps + a screenshot.
- **Acceptance criteria:**
  - [ ] 4 people played it fully
  - [ ] Bug issues created and assigned to the owner of the broken file

#### G2 · Bug fix day
- **Owner:** Everyone · **Day:** 6 · **Labels:** `bug`
- **Description:** Fix your own bugs. No new features. Nice-to-haves only if you have 0 bugs left.
- **Acceptance criteria:**
  - [ ] All `bug` issues closed or moved to M2 by Panha
  - [ ] Full play from MainMenu → Win → Play Again with 0 errors

#### G3 · Final Windows build
- **Owner:** Dina · **Day:** 7 · **Labels:** `test`
- **Description:** File → Build Profiles → Windows → Build into a `Build/` folder (it is ignored by Git). Test on a different computer if possible.
- **Acceptance criteria:**
  - [ ] The `.exe` runs: menu → game → win → quit
  - [ ] Build zipped and shared with the team (not in Git)
  - [ ] GitHub release/tag `v1.0`

#### G4 · README, screenshots, and demo video
- **Owner:** Panha (Viset + Soth help) · **Day:** 7 · **Labels:** `test`
- **Description:** Update the root `README.md`: game description, controls, how to open in Unity, team roles, and credits (from ASSETS.md). Add 3 screenshots and a 1-minute gameplay video.
- **Acceptance criteria:**
  - [ ] README is complete; screenshots in `docs/images/`
  - [ ] Credits list every asset pack

---

## Milestone 2 backlog (`M2` label — do NOT start before M1 is merged)

| ID | Title | Short description |
|---|---|---|
| M2-1 | Total timer on HUD | 5-minute countdown, `GameTimer.cs` + `UIManager.SetTimer()` |
| M2-2 | Lose screen | Time = 0 → Lose panel with Try Again |
| M2-3 | Speed bonus | Extra money for fast deliveries |
| M2-4 | Pause menu | Esc → Resume / Menu |
| M2-5 | Pizza box in hands | Show a box model while carrying |
| M2-6 | Footsteps + better lighting | Polish |

## Issue count per person (Milestone 1)

| Person | Issues |
|---|---|
| Dina | A1, A4, B1, B2, B3, B4, B5, B6, G3 (+ all reviews/merges) |
| Viset | C1, C2, C3, C4, C5, C6, C7 |
| Panha | A2, A5, D1, D2, D3, D4, D5, G4 (+ lead) |
| Soth | E1, E2, E3, E4, E5, E6 |
| Everyone | A3, G1, G2 |