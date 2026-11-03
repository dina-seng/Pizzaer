# Pizzaer — Work Rules & Role Guides

**Why this file exists:** 4 people work on one Unity project. If everyone names things differently, edits the same files, or puts files anywhere, joining the work together (integration) becomes a mess and work gets lost.
So we all follow the **same rules**. A pull request (PR) is merged **only if it passes the checklist for your role**.

How to use this file:
0. Not set up yet? Do [QUICK_START.md](QUICK_START.md) first.
1. Read **Part 1 (rules for everyone)** once.
2. Read **your role guide** in Part 2.
3. Before you open a PR, tick **your checklist**. Dina checks it before merging.

---

# Part 1 — Rules for everyone

## 1.1 The 10 golden rules

1. **One owner per file.** Every scene, prefab and script has one owner (see table 1.5). Only the owner edits it.
2. **Only Dina edits `Town.unity`.** You test in your own Sandbox scene.
3. **Work only on an issue.** No issue = no work. One issue = one branch = one PR.
4. **Never work on `main`.** Always make a branch.
5. **Pull `main` every morning** before you start.
6. **Small PRs, every day.** Don't keep work on your computer for 3 days.
7. **Everything goes in `Assets/_Pizzaer/`.** Never edit files inside imported packs.
8. **Move/rename files only inside Unity** (never in Windows Explorer), so `.meta` files stay correct.
9. **Zero red errors** in the Console before you push.
10. **Stuck for more than 30 minutes? Ask** in the team chat. Don't stay stuck for a whole day.

## 1.2 Naming rules

| Thing | Rule | Examples |
|---|---|---|
| Scripts | PascalCase, file name = class name | `DeliveryManager.cs`, `InteractZone.cs` |
| Prefabs | `Category_Name` | `Player_Pizzaer`, `Zone_House`, `Env_House_03`, `UI_Canvas`, `Core_GameManager`, `Marker_Target`, `NPC_Customer` |
| Prefab categories | `Player_` `Zone_` `Marker_` `NPC_` `Core_` `UI_` `Env_` | — |
| Scenes | PascalCase | `MainMenu`, `Town`, `Sandbox_Viset` |
| Materials | `M_Name` | `M_MarkerGlow`, `M_Grass` |
| Sprites (UI images) | `SPR_Name` | `SPR_PanelBrown`, `SPR_ButtonYellow` |
| Music | `MUS_Name` | `MUS_Menu`, `MUS_Town` |
| Sound effects | `SFX_Name` | `SFX_Pickup`, `SFX_Deliver`, `SFX_Wrong`, `SFX_Win`, `SFX_Click` |
| GameObjects in scene | PascalCase, clear names (no "GameObject (1)") | `HouseSign_03`, `Tree_Big` |
| Hierarchy folders | `--- NAME ---` (empty GameObject at 0,0,0) | `--- ENVIRONMENT ---` |
| Code: variables | camelCase | `houseNumber`, `hasPizza` |
| Code: methods | PascalCase | `ShowDialogue()`, `MoveTo()` |

## 1.3 Tags and layers

| Tag | Put it on | Who adds |
|---|---|---|
| `Player` | Root of `Player_Pizzaer` (object with CharacterController) | Viset |
| `Zone` | Root of `Zone_Shop` and `Zone_House` | Viset |
| everything else | `Untagged` | — |

- **Layers:** everything on **Default**.
- New tags or layers? Only **Dina** adds them (they live in `ProjectSettings`). Ask in chat first.

## 1.4 Prefab rules (for every prefab)

1. **Root object** at position (0,0,0), rotation (0,0,0), scale (1,1,1).
2. **Scripts go on the root**, unless the doc says otherwise.
3. **Pivot at the bottom center** for things you place on the ground (houses, NPCs, props).
4. **Real size:** 1 Unity unit = 1 meter. The player is about 1.8 m tall. Fix size in the model's **Import Settings → Scale Factor**, not by scaling in the scene.
5. **Works alone:** drag your prefab into an empty scene (with `Core_GameManager` if needed). It must work with no errors.
6. **No missing things:** no "Missing Script", no pink materials, no "None (Missing)" fields.
7. **Never Unpack a prefab** in Town or Sandbox. If you need a change, change the prefab or make a **Prefab Variant**.
8. **Imported pack prefabs → make a Variant** in `_Pizzaer/Prefabs/` and use the Variant.
9. **Allowed scene overrides** (changes on a prefab copy in the scene, done by the scene owner): position, rotation, and `houseNumber` on `Zone_House`. Nothing else. Other changes go into the prefab itself.

## 1.5 Ownership table

| File / Folder | Owner | Others |
|---|---|---|
| `Scenes/Town.unity` | **Dina** | Never edit |
| `Scenes/MainMenu.unity` | **Soth** | Never edit |
| `Scenes/Sandbox/Sandbox_<Name>.unity` | That person | Never open someone else's |
| `Prefabs/Environment/*` (`Env_`), `Models/`, `Materials/` | **Dina** | Ask Dina |
| `Prefabs/Player/*`, `Prefabs/Gameplay/*` (`Zone_`, `Marker_`, `NPC_`) | **Viset** | Ask Viset |
| `Prefabs/Core/Core_GameManager` | **Panha** | Ask Panha |
| `Prefabs/Core/Core_Audio`, `Prefabs/UI/*`, `Art/UI/`, `Audio/` | **Soth** | Ask Soth |
| `Scripts/Core/*`, `Scripts/UI/UIManager.cs` | **Panha** | Ask Panha |
| `Scripts/Gameplay/*`, `Scripts/UI/MainMenu.cs`, `Scripts/Audio/*` | **Viset** | Ask Viset |
| `ProjectSettings/` (tags, layers, build profiles, player settings) | **Dina** | Only in an issue that says so |
| `Packages/` (package list) | **Dina** | Only in an issue that says so (for example, the Starter Assets import) |
| `docs/STORY.md` | **Soth** | Comment only |
| `docs/PLAN.md`, the GitHub board | **Panha** | Comment only |
| Other `docs/*.md` | Panha | PR with a small change is OK |

**The "attach" rule:** the person who **owns the prefab** adds the script component and drags the references. The script writer writes **"How to hook up"** steps in the PR (see 1.8).

**The "lock" rule:** if you really must edit a shared file (rare), write in the team chat:
`🔒 editing Core_GameManager` … and when done: `🔓 Core_GameManager done, PR #12`.
Nobody touches a locked file.

## 1.6 Git names

| What | Rule | Example |
|---|---|---|
| Branch | `feature/<issue#>-short-name` or `fix/<issue#>-short-name` | `feature/14-interact-zone`, `fix/31-marker-too-low` |
| Commit message | `#<issue> Verb + what` | `#14 Add InteractZone trigger logic` |
| PR title | `#<issue> Issue title` | `#14 InteractZone script + zone prefabs` |
| PR description | must contain `Closes #<issue>` | `Closes #14` |

## 1.7 How to do one issue (every time, same steps)

1. On the board, move your issue to **In Progress**.
2. Pull `main` (GitHub Desktop: *Fetch origin* → *Pull*).
3. Create a branch from `main` (name rule above).
4. Open Unity. Work **only** in your files + your Sandbox scene.
5. Save often: **Ctrl+S** (scene) and **File → Save Project** (prefabs and settings).
6. Test in your Sandbox. Clear the Console, press Play, play the feature, then check for **0 red errors**.
7. Commit small steps with good messages. Check that each new file has its `.meta` file.
8. Before the PR: merge the latest `main` into your branch, open Unity again, and test again.
9. Push and open a **Pull Request**. Fill in the template and tick your role checklist. Add a screenshot or GIF.
10. Move the issue to **In Review**. Fix what Dina asks. After the merge, delete your branch.

## 1.8 "How to hook up" notes (in the PR)

When your work must be attached or placed by someone else, write exact steps in the PR. Example:

```
How to hook up (for Soth):
1. Open Prefabs/UI/UI_Canvas.
2. Add Component → UIManager on the root.
3. Drag HUD/MoneyText → Money Text, HUD/OrderText → Order Text, HUD/PromptPanel → Prompt Panel.
4. Drag DialoguePanel, DialoguePanel/SpeakerText, DialoguePanel/LineText into the Dialogue fields.
5. Drag WinPanel and WinPanel/WinMoneyText into the Win fields.
6. PlayAgainButton → OnClick → UI_Canvas → UIManager.PlayAgain. MenuButton → UIManager.BackToMenu.
```

## 1.9 Definition of Done (for EVERY PR)

An issue is **done** only when all of these are true:

- [ ] All **acceptance criteria** in the issue are met
- [ ] Tested in my Sandbox scene (or Town for Dina), with **0 errors** in the Console
- [ ] Follows the naming rules and folder rules
- [ ] Only files I own were changed (check the PR's *Files changed* tab)
- [ ] Every new asset has its `.meta` file. No `Library/`, `Temp/`, `.csproj`, or `.sln` files.
- [ ] Screenshot or GIF in the PR
- [ ] "How to hook up" notes, if someone else must attach or place it
- [ ] My **role checklist** (Part 2) is ticked

---

# Part 2 — Role guides

## 2.1 🧑‍💻 Script Builder — Viset & Panha

**Your job:** write C# scripts, and build the prefabs you own (Viset: player, zones, marker, NPC). Make sure they work alone.

**How to work:**
1. Start from the **starter code** and method names in [ARCHITECTURE.md](ARCHITECTURE.md) §8.
2. Test with simple cubes in your Sandbox. Don't wait for the town or the UI.
3. If you need something that is not ready yet, use `Debug.Log` for now. Example: `Debug.Log("[Zone] Player entered shop");`
4. When your script must go on someone else's prefab, write "How to hook up" notes.

**Code rules:**
- File in the right folder: `Scripts/Core`, `Scripts/Gameplay`, `Scripts/UI`, or `Scripts/Audio`.
- **Keep public method names** from ARCHITECTURE.md. If you must change one, update ARCHITECTURE.md **in the same PR** and tell the team.
- Use the **new Input System** only: `Keyboard.current.eKey.wasPressedThisFrame`. Never `Input.GetKeyDown`.
- Don't use `GameObject.Find("Name")` with strings. Use Inspector fields, `FindFirstObjectByType<T>()`, or `ClassName.Instance`.
- Messages go one way: **Zones → DeliveryManager → UI / Marker / Audio**. The UI never changes game data.
- `public` fields only for things set in the Inspector. Add `[Header("...")]` and `[Tooltip("...")]` so others understand them.
- One short comment (in simple English) above each public method.
- `Debug.Log` must start with a tag: `[Delivery]`, `[Zone]`, `[UI]`, `[Audio]`. Don't log every frame inside `Update`.
- If something is missing, show a clear error: `Debug.LogError("[Delivery] House #3 is not in the scene!");`
- Use 4 spaces, and always put `{ }` braces on `if` blocks with more than 1 line.

**✅ Script Builder merge checklist**
- [ ] Script is in the correct `Scripts/` sub-folder, and the file name = class name
- [ ] Public method names match ARCHITECTURE.md (or ARCHITECTURE.md is updated in this PR)
- [ ] New Input System only; no `GameObject.Find("...")`
- [ ] Clear Console → Play → **0 errors, 0 warnings from my scripts**
- [ ] Logs use a `[Tag]` prefix, with no spam in `Update`
- [ ] Missing references give a clear `Debug.LogError` (no `NullReferenceException`)
- [ ] My prefabs follow 1.4 (root at 0,0,0, correct tag, works in an empty scene)
- [ ] Tested in my Sandbox; GIF/screenshot added
- [ ] "How to hook up" notes added (if needed)
- [ ] I did **not** change `Town.unity`, other people's prefabs, `ProjectSettings/`, or `Packages/` (unless the issue says so)

## 2.2 🏗️ Level Builder & Integrator — Dina

**Your job:** build the town, make the `Env_` prefabs, and **put everyone's prefabs into `Town.unity`** (integration).

**How to work (building):**
1. Import only the models you need. Copy the **FBX + its Textures folder** together into `_Pizzaer/Models/<PackName>/`. Kenney models need their texture next to them.
2. In the model's **Import Settings**, tick **Generate Colliders** (or add a Box/Mesh Collider) and check the **Scale Factor** against the player.
3. Use grid snapping: hold **Ctrl** while moving. Set the snap size to the road tile size, so roads line up.
4. Make each house a prefab, `Env_House_01`…`05`, with a big number sign and a `Zone_House` child at the front door.
5. Keep the Hierarchy in the layout from ARCHITECTURE.md §1. Nothing loose at the top level.
6. Tick **Static** on objects that never move (buildings, roads, trees).

**How to work (integrating):**
1. Integrate **after** the prefab's PR is merged to `main`. Never take files from someone's unmerged branch.
2. Follow their "How to hook up" notes exactly.
3. Only these scene overrides are allowed: position, rotation, and `houseNumber`. If a prefab needs other changes, ask its owner.
4. After integrating, play the full loop in Town. If something breaks, open a `bug` issue for the owner. Don't fix their files yourself.
5. Make **one integration PR per day** that lists what you added.

**✅ Level Builder / Integrator merge checklist**
- [ ] Hierarchy follows the ARCHITECTURE.md §1 layout, with no loose objects and clear names
- [ ] Every building, wall, and prop the player can touch has a collider
- [ ] Map edges are closed (invisible walls). I ran along all edges for 1 minute and could not fall off or get out.
- [ ] Walk test: no place where the player gets stuck, and the shop → farthest house walk is under 60 seconds
- [ ] Scale check: the player fits through doors and looks right next to houses
- [ ] No pink materials, and all objects are on the Default layer
- [ ] House signs 1–5 are readable from 10 m, and each `Zone_House` has the matching `houseNumber`
- [ ] Only allowed overrides on other people's prefabs (position, rotation, houseNumber)
- [ ] Play mode: 0 errors. Game view Stats shows about 60 FPS or more.
- [ ] Screenshot of the town from above in the PR

## 2.3 🎨 UI, Art, Sound & Writing — Soth

**Your job:** build all screens (UI layout) as prefabs, attach the UI scripts, find and import music and sounds, and write all game text.

**How to work (UI):**
1. Build everything inside one prefab: `Prefabs/UI/UI_Canvas`. The main menu lives in `MainMenu.unity`.
2. **Canvas Scaler:** *Scale With Screen Size*, reference **1920 × 1080**, Match **0.5**.
3. Use **anchors** for every element (for example, money at the top-left, dialogue at the bottom-center). Test in the Game view at 16:9 and 16:10.
4. Use **TextMeshPro** only. Body text is at least size 28, titles at least 48. Put a dark panel behind light text.
5. Turn **Raycast Target OFF** on images and texts that are not buttons, so they don't block clicks.
6. UI images go in `Art/UI/` with a `SPR_` name. Set **Texture Type = Sprite (2D and UI)**.
7. **Use these exact object names.** The scripts and hook-up notes depend on them:

```
UI_Canvas            (UIManager on root)
├── HUD
│   ├── MoneyText
│   ├── OrderText
│   └── PromptPanel
│       └── PromptText        "Press E"
├── DialoguePanel
│   ├── SpeakerText
│   └── LineText
└── WinPanel
    ├── WinTitleText
    ├── WinMoneyText
    ├── PlayAgainButton
    └── MenuButton

MainMenu scene:
Canvas               (MainMenu script on root)
├── TitlePanel
│   ├── TitleText
│   ├── PlayButton
│   └── QuitButton
└── StoryPanel
    ├── StoryText
    └── StartButton
EventSystem
```

**How to work (sound):**
1. Prefer **.ogg** files. Name them `MUS_` or `SFX_`. Put them in `Audio/Music` or `Audio/SFX`.
2. Import settings: Music → **Load Type: Streaming**. SFX → **Decompress On Load**.
3. `Core_Audio` prefab: one AudioSource "Music" (Loop ✔, Play On Awake ✔, volume about 0.4), one AudioSource "SFX" (volume about 0.8), and the `AudioManager` script with clips assigned.
4. Every sound or music file you add gets a line in **ASSETS.md** (name, link, license).

**How to work (writing):**
1. Write all text in `docs/STORY.md`: the story intro, the chef lines, and 5 orders (house, pizza, customer name, customer line, reward).
2. Use simple English, and keep each dialogue line **15 words or fewer** so it fits in the box.
3. Panha copies the orders into `Core_GameManager`. You check the result in the game.

**✅ UI / Sound / Writing merge checklist**
- [ ] UI is inside `UI_Canvas` (or the MainMenu scene), and object names match the list above exactly
- [ ] Canvas Scaler set to 1920×1080, Match 0.5; anchors set; checked at 16:9 and 16:10
- [ ] TextMeshPro only; text is readable (size ≥ 28, good contrast)
- [ ] Raycast Target OFF on non-clickable elements; every button's OnClick is linked
- [ ] Sprites in `Art/UI/` with `SPR_` names; audio in `Audio/` with `MUS_`/`SFX_` names
- [ ] Music loops with no gap; SFX volumes are balanced (not louder than the music by too much)
- [ ] Every new asset is listed in ASSETS.md with its license
- [ ] Text in STORY.md: simple English, ≤ 15 words per dialogue line, no typos
- [ ] Tested in my Sandbox (UI) or MainMenu scene; screenshot added

## 2.4 ✅ Reviewer & Merger — Dina

**Your job:** protect `main`. `main` must **always open and play** with 0 errors.

**Merge steps for each PR:**
1. Read the PR: does it say `Closes #x`? Is the role checklist ticked?
2. Open **Files changed**. Are only the author's own files changed? Is anything in the wrong folder? Are there `.meta` files? Are big files "Stored with Git LFS"?
3. Pull the branch (GitHub Desktop: *Current branch* → the PR branch). Open Unity. Wait for import. Check that there are 0 errors.
4. Test the feature (in Sandbox or Town).
5. OK → **Squash and merge**, then **Delete branch**. Move the card to **Done**. Write in chat: `✅ merged #14 — everyone pull main`.
6. Not OK → write a clear comment (what is wrong, which checklist line). Move the card back to **In Progress**.

**Rules for the reviewer:**
- Merge at least **once a day before 9 PM**, so everyone can pull fresh work.
- **Reject** any PR that edits `Town.unity` (unless it's yours), `ProjectSettings/`, or `Packages/` when the issue does not say so.
- **Dina's own PRs** are reviewed by **Panha** (same steps).
- If `main` breaks: stop merging, find the PR that broke it, and **revert** it (GitHub: PR page → *Revert*). Fix it later in a new PR.

**✅ Reviewer checklist (Dina ticks it in the review)**
- [ ] Linked issue, correct milestone and labels
- [ ] No merge conflicts with `main`
- [ ] Only allowed files changed, every new asset has a `.meta`, no junk files
- [ ] Project opens with 0 errors on my computer
- [ ] Feature works as the acceptance criteria say
- [ ] The author's role checklist is complete

## 2.5 🧭 Team Lead — Panha

**Your job:** keep the team moving, keep the board true, and cut scope early.

- **Daily stand-up (10 minutes, same time each day, chat or call):** each person says (1) what I finished, (2) what I do today, (3) what blocks me.
- **Board check (morning + evening):** every card is in the right column and has an owner and a day.
- **Late by 1 day?** Don't ask people to stay up all night. Cut scope: move the issue to **nice-to-have** or **M2**.
- **Feature freeze at the end of Day 5:** after that, only bug fixes and polish. No new features.
- You are also a Script Builder, so follow 2.1 for your own code.

---

# Part 3 — When things go wrong

| Problem | What to do |
|---|---|
| **Merge conflict in a `.unity` or `.prefab` file** | Don't try to edit the text. Keep the owner's version ("use theirs" or "use mine" in GitHub Desktop), then redo your small change in Unity. Ask Dina if unsure. |
| **Merge conflict in a `.cs` file** | Open it in VS Code. Keep both changes carefully. Ask the script owner. |
| **Unity shows errors after pulling `main`** | Wait for the import to finish. Then close Unity, delete the `Library/` folder, and open again. Still broken? Tell Dina. |
| **Pink materials** | Window → Rendering → Render Pipeline Converter → Material Upgrade |
| **"Missing Script" on a prefab** | The script was renamed or moved outside Unity. Tell the script owner. |
| **A file has no `.meta`, or `.meta` has no file** | You moved or deleted something outside Unity. Undo it, and do it again inside Unity. |
| **Someone edited my file** | Don't fight it. Talk in chat, decide whose version stays, and remind them about the ownership table. |
| **Stuck > 30 minutes** | Ask in chat: what you tried, a screenshot of the error, and your branch name. |