window.addEventListener('load', function () {
  registerToggles();
});

function registerToggles() {
  const elements = document.querySelectorAll('[data-toggle]');
  elements.forEach(el => {
    el.addEventListener('click', function () {
      let targetElement = document.getElementById(el.getAttribute('data-target'));
      let targetClass = el.getAttribute('data-toggle');
      targetElement.classList.toggle(targetClass);
    });
  });
}