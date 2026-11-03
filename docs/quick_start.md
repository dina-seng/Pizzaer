# Pizzaer — Quick Start

Read this first. It has 4 short checklists:

- **A. First-time setup**: do it once, about 1 hour
- **B. Extra setup for your role**: do it once
- **C. Before you start EVERY task**: about 2 minutes
- **D. End of every day**: about 2 minutes

Details are in [GITHUB_GUIDE.md](GITHUB_GUIDE.md) and [WORK_RULES.md](WORK_RULES.md).

---

## Day 1 order (important!)

1. **Dina** goes first: A1 (fix LFS, clean the template, folders, scenes) and A4 (protect `main`, add docs + PR template). Then she merges them and writes in chat: `✅ setup merged`.
2. **Everyone else** clones **after** that message. If you cloned earlier, just **Pull**.
3. Everyone makes their **Sandbox scene PR** (A3 step 8 below). This is your practice PR.
4. **Panha** creates the board and issues (A2) and the script stubs (A5).

---

## A. First-time setup (everyone, once)

- [ ] **1. Accounts**
  - Make a GitHub account (or use yours) and accept Dina's invite email.
  - Sign in to **Unity Hub** with a Unity account (Personal license is free).
- [ ] **2. Install**
  - **Unity Hub**, then Unity **6000.3.8f1** exactly, with the **Windows Build Support** module.
  - A code editor: **Visual Studio Community** (you can tick it in the Unity installer) or **VS Code**.
  - **Git**, **Git LFS**, and **GitHub Desktop**. Links are in GITHUB_GUIDE.md Step 0.
- [ ] **3. Run once in a terminal** (Git Bash or PowerShell):
  ```bash
  git lfs install
  git config --global user.name "Your Name"
  git config --global user.email "you@example.com"
  ```
- [ ] **4. Clone** with GitHub Desktop:
  - File → Clone repository → `dina-seng/Pizzaer`
  - Save it to a short path like `C:\Projects\Pizzaer`, with no spaces and no Khmer letters.
- [ ] **5. Open in Unity**
  - Unity Hub → Add → Add project from disk → choose the `Pizzaer` folder → open with **6000.3.8f1**.
  - ⏳ The first open takes 5–15 minutes, because Unity builds `Library/`. Wait.
  - If Unity asks **"Import TMP Essentials"**, click **Import**.
- [ ] **6. Set your code editor**
  - Edit → Preferences → External Tools → **External Script Editor** = Visual Studio (or VS Code).
  - VS Code users: install the **"Unity"** extension by Microsoft.
- [ ] **7. Check the project** (look only, don't change anything):
  - The **Console** shows 0 red errors.
  - Edit → Project Settings → Player → **Active Input Handling** = *Input System Package (New)*.
- [ ] **8. Create your Sandbox scene** (your first PR):
  1. GitHub Desktop: Current branch = `main` → **Pull** → New branch `feature/<A3 issue#>-sandbox-<yourname>`.
  2. Unity: File → New Scene → **Basic (URP)** → Create.
  3. Add a **Plane** (GameObject → 3D Object → Plane), position (0,0,0), scale (10,1,10).
  4. File → Save As → `Assets/_Pizzaer/Scenes/Sandbox/Sandbox_<YourName>.unity`
  5. GitHub Desktop: commit **the scene + its `.meta`** with the message `#<issue> Add Sandbox_<YourName>`, then **Push**, then **Create Pull Request**.
  6. Fill in the PR template. Dina merges it. 🎉 You now know the full workflow.
- [ ] **9. Read the docs**
  - [OVERVIEW.md](OVERVIEW.md), all of it.
  - [ARCHITECTURE.md](ARCHITECTURE.md): the parts about your scripts and prefabs.
  - [WORK_RULES.md](WORK_RULES.md): Part 1 and your role in Part 2.
- [ ] **10. Join the team chat** and know the daily stand-up time.

---

## B. Extra setup for your role (once)

| Person | Extra setup |
|---|---|
| **Dina** | Add Viset, Panha and Soth as Collaborators. Optional: Unity Smart Merge (GITHUB_GUIDE.md Step 3). Download the Kenney City Kits, Food Kit and Car Kit, and unzip them **outside** the project folder. |
| **Viset** | Open the Starter Assets link in ASSETS.md and click **Add to My Assets** (signed in with the same Unity account as Unity Hub). Learn where **Window → Package Management → Package Manager → My Assets** is. |
| **Panha** | Make sure your code editor opens when you double-click a `.cs` file in Unity, with colors and autocomplete working. Read ARCHITECTURE.md §5 and §8 fully: you own the "boss" script. |
| **Soth** | Download the Kenney UI Pack, Interface Sounds, RPG Audio and the music from ASSETS.md (unzip **outside** the project). In the Game view, add a **1920×1080** resolution option (Game tab → aspect dropdown → **+**). |

---

## C. Before you start EVERY task (2 minutes)

- [ ] **1. Get the newest `main`:** GitHub Desktop → Current branch = `main` → **Fetch origin** → **Pull**.
- [ ] **2. Read your issue:** it's assigned to you, and you understand the **acceptance criteria**. Check that the issues it **depends on** are merged.
- [ ] **3. Move the card** to **In Progress** on the board.
- [ ] **4. Make a new branch** from `main`: `feature/<issue#>-short-name`.
- [ ] **5. Open Unity**, wait for the import, then Console → **Clear**. Are there red errors already? Tell Dina **before** you start. They are not your bugs.
- [ ] **6. Open YOUR Sandbox scene.** Not Town, unless you are Dina.
- [ ] **7. Shared file?** Lock it in chat first: `🔒 editing X`.

Now work. When you finish, follow WORK_RULES.md §1.7 steps 5–10 and the PR template.

---

## D. End of every day (2 minutes)

- [ ] Save in Unity: **Ctrl+S** and **File → Save Project**.
- [ ] **Commit and Push** your branch, even if it's not finished. Then your work is safe on GitHub.
- [ ] Finished? **Open the PR** and move the card to **In Review**. Not finished? Leave it **In Progress** and write a short comment on the issue about what is left.
- [ ] Unlock shared files in chat: `🔓 X done`.
- [ ] Blocked? Write it in chat now, not tomorrow.