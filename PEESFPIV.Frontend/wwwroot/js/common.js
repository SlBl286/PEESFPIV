if (window.innerWidth > 992) {
  AOS.init({
    duration: 1200, // Thời gian mặc định cho tất cả các animation
    easing: 'ease-in-out', // Easing mặc định
    offset: 100, // Khoảng cách mặc định trước khi kích hoạt animation
    delay: 100, // Độ trễ mặc định
    once: true, // Animation chỉ chạy 1 lần
  });
} else {
  // Hủy các hiệu ứng AOS
  AOS.refreshHard();
  const aosElements = document.querySelectorAll('[data-aos]');
  aosElements.forEach(el => el.removeAttribute('data-aos'));
}