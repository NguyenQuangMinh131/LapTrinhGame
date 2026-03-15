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

### 5. Bài tập Lab 4: Video Player & Global Audio
Để kiểm tra phần xử lý Video và Audio toàn cục:
- **Đường dẫn Scene:** `Assets/Scenes/Lab4`
- **Nội dung:**
  - **Global Audio (`Lab3_GlobalAudio.cs`):**
    - Nhấn `M` để Mute/Unmute toàn bộ âm thanh (AudioListener).
    - Nhấn `P` để Pause/Resume toàn bộ âm thanh.
  - **Video Player (`Lab5_Video.cs` & `Lab7_VideoEvents.cs`):**
    - Nhấn `V` để phát Video.
    - **Tính năng Skip:** Có nút "SKIP VIDEO" (góc phải màn hình) để bỏ qua video ngay lập tức.
    - **Event Handling:** Xử lý sự kiện khi video chuẩn bị xong và khi kết thúc (tự động tắt player).

### 6. Demo3 - Tương tác Enemy & Bắn tự động
Để kiểm tra phần Demo3:
- **Đường dẫn Scene:** `Assets/Scenes/Demo3`
- **Scripts** (nằm tại `Assets/Scrpit/Demo3/`):
  - `EnemyHealth.cs`: Xử lý va chạm trigger để hủy đối tượng và tạo hiệu ứng nổ.
  - `PShooting1.cs`: Script bắn súng liên tục khi giữ chuột trái, sinh ra đạn.

### 7. Bài tập Lab 5: Physics & Character Control
Để kiểm tra phần xử lý Vật lý và Điều khiển nhân vật, các script nằm tại `Assets/Scrpit/Lab5/`:
- **Nội dung:**
  - `CharControl.cs`: Điều khiển nhân vật di chuyển, nhảy và xử lý va chạm với môi trường.
  - `OneWayPlatform.cs`: Hệ thống nền tảng một chiều (cho phép nhảy từ dưới lên).
  - `TriggerTest.cs` & `CollisionTest.cs`: Phân biệt sự kiện Trigger (xuyên qua) và Collision (va chạm vật lý).
  - `ForceTest.cs` & `CharacterPush.cs`: Tương tác vật lý, đẩy các vật thể 3D/2D.
  - `Conveyor3D.cs`: Giả lập băng chuyền vận chuyển vật thể.

### 8. Demo4 - Health System & Combat
Hệ thống máu và chiến đấu (Combat) được xây dựng trong Demo4. Các script chính nằm tại `Assets/Scrpit/Demo4/`:
- **Nội dung:**
  - `Health.cs`: Class cơ sở (Base Class) quản lý máu, các hàm `TakeDamage`, `Die`.
  - `ShipHealth.cs`: Kế thừa từ `Health`, quản lý máu Player và hiệu ứng nổ khi chết.
  - `EnemyHealth.cs`: Kế thừa từ `Health`, quản lý máu Enemy, log thông báo và hiệu ứng nổ.
  - `EnemyAttack.cs`: Xử lý logic Enemy gây sát thương cho Player khi va chạm.

### 9. Demo5 - Âm thanh, Game Over UI & Main Menu
Để kiểm tra phần Demo5:
- **Đường dẫn Scene:** `Assets/Scenes/Demo5`
Kế thừa từ các phần trước, phần này bổ sung thêm các tính năng về âm thanh và luồng (flow) của game:
- **Nội dung:**
  - **Handling sounds:** 
    - Thêm Background Music cho Battle Scene.
    - Thêm Audio Source phát âm thanh khi bắn đạn (Bullet) và hiệu ứng vụ nổ (Explosion).
  - **Game Over UI:** Tạo Canvas hiển thị màn hình Game Over với tùy chọn "Return to Main Menu".
  - **Main Menu Scene (`MainMenu.unity`):** 
    - Thiết kế giao diện Menu chính bao gồm Background không gian, Game Title và nút "Play Game".
    - Bổ sung Background Music riêng cho màn hình Menu.
    - Script `MainMenu.cs`: Gắn sự kiện `OnPlayButtonClicked` để load sang scene `Battle` thông qua `SceneManager.LoadScene()`.
    - Quản lý thứ tự Scene trong **Build Settings**.
### 10. Lab 6:
### 11. Demo6: Xử lý Game Over, Game Win & Cuộn Background (Looping Background)
Để kiểm tra phần xử lý kết thúc game và hiệu ứng background trôi liên tục, các script nằm tại `Assets/Scrpit/Demo5/` và `Assets/Scrpit/Demo6/`:
- **Nội dung:**
  - **Handling Game Over:** Hiển thị Game Over UI khi người chơi (Ship) chết. Sử dụng C# Event `onDead` từ `Health.cs` để kích hoạt `BattleFlow.OnGameOver()`.
  - **Handling Game Win:** Tạo biến `static LivingEnemyCount` trong `EnemyHealth.cs` để đếm số lượng enemy còn sống. BattleFlow sẽ theo dõi biến này bằng hàm `Update()`, nếu `<= 0` sẽ gọi `OnGameWin()`.
  - **Looping Background:** 
    - Tạo một 3D Quad, thay đổi **Shader thành Unlit/Texture** và áp vật liệu (Material) có tùy chọn Wrap Mode là Repeat.
    - Script `ScrollingBackground.cs`: Thay đổi `mainTextureOffset` của `Material` liên tục theo `Time.time` nhằm tạo cảm giác phi thuyền đang bay tới trước.
  - **Return to Main Menu:** Load lại màn hình Menu khi game kết thúc thông qua `SceneManager.LoadScene()`.

### 12. Bài tập Lab 7: UI & Event System
Để kiểm tra phần xử lý giao diện người dùng (UI), các script nằm tại `Assets/Scrpit/lab7/`:
- **Đường dẫn Scene:** `Assets/Scenes/Lab7/Lab7.unity`
- **Nội dung:**
  - `UIManager.cs`: Chứa các hàm cơ bản để quản lý Menu như bắt đầu game (`StartGame()`), thoát game (`ExitGame()`), và hiển thị/ẩn bảng Cài đặt (`settingsPanel`).
  - `DeLog.cs`: Dùng để gắn vào các Nút bấm (Button), cung cấp hàm `LogMessage()` in tin nhắn ra Console để kiểm thử sự kiện (OnClick Event).

Demo 7