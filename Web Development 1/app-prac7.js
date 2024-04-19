// Get references to HTML elements
const taskInput = document.getElementById('taskInput');
const addTaskBtn = document.getElementById('addTaskBtn');
const taskList = document.getElementById('taskList');

// Check if tasks exist in local storage, otherwise initialize an empty array
let tasks = JSON.parse(localStorage.getItem('tasks')) || [];

// Function to render tasks on the page
function renderTasks() {
  // Clear existing tasks
  taskList.innerHTML = '';

  // Loop through tasks and create list items
  tasks.forEach((task, index) => {
    const li = document.createElement('li');
    li.textContent = task;
    
    // Add delete button to each task
    const deleteBtn = document.createElement('button');
    deleteBtn.textContent = 'Delete';
    deleteBtn.addEventListener('click', () => {
      deleteTask(index);
    });
    
    li.appendChild(deleteBtn);
    taskList.appendChild(li);
  });
}

// Function to add a new task
function addTask() {
  const task = taskInput.value;
  if (task) {
    tasks.push(task);
    localStorage.setItem('tasks', JSON.stringify(tasks));
    renderTasks();
    taskInput.value = '';
  }
}

// Function to delete a task
function deleteTask(index) {
  tasks.splice(index, 1);
  localStorage.setItem('tasks', JSON.stringify(tasks));
  renderTasks();
}

// Event listener for add task button
addTaskBtn.addEventListener('click', addTask);

// Render initial tasks
renderTasks();