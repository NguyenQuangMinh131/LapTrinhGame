# Bài tập Unity - Lập Trình Game

### 1. Bài tập Mathematics in Unity (Bài tập hình khối)
Để kiểm tra phần bài tập về Hệ tọa độ, Local/World Space và Camera:
- **Đường dẫn Scene:** `Assets/Scenes/Math.unity`
- **Nội dung:**
  - Parent/Child object demo Local vs World Space.
  - Script `WorldToScreen.cs` in tọa độ ra Console.

### 2. Bài tập Space Shooter
Để kiểm tra phần game bắn súng 2D:
- **Đường dẫn Scene:** `Assets/Scenes/Demo part 1 SpaceShooter/`
- **Nội dung:**
  - Di chuyển tàu (Player Movement) bằng chuột.
  - Xử lý Particle System (Hiệu ứng động cơ).
  - Background & Canvas.

### 3. Bài tập Chương 3: Lab C3
Để kiểm tra các bài Lab về Vòng đời (Lifecycle), Vector, Quaternion và Observer Pattern:
- **Đường dẫn Scene:** `Assets/Scenes/Chương 3/`
- **Nội dung:**
  - **Lifecycle:** Demo vòng đời Awake, Start, Update, OnDisable, OnDestroy.
  - **Movement & Rotation:** Di chuyển vector chuẩn hóa, xoay tháp pháo (LookAt/Slerp), tính góc (Signed Angle).
  - **Observer Pattern:** Hệ thống máu & UI sử dụng C# Event và UnityEvent (Binding).

### 4. Demo2 - Basic Shooting
Để kiểm tra phần Demo2:
- **Scene**: `Battle.unity`
- **Scripts** (nằm tại `Assets/Scrpit/Demo2/`):
  - `Bullet.cs`: Script điều khiển viên đạn bay lên theo trục Y với tốc độ `flySpeed`.
  - `PShooting.cs`: Script gắn vào người chơi, có nhiệm vụ sinh ra viên đạn (`bulletPrefabs`) sau mỗi khoảng thời gian `shootingInterval`.