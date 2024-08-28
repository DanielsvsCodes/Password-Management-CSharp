# Password-Management-CSharp

## Overview

This is a multi-service application designed to securely store and manage passwords. The application consists of several backend services and a frontend built using .NET MAUI. The backend services include:

1. **Authentication Service**: Manages user authentication.
2. **Notification Service**: Handles notifications for the application.
3. **Password Storage Service**: Securely stores user passwords.
4. **User Management Service**: Manages user data and roles.

The frontend is a cross-platform application built with .NET MAUI and requires WinUI 3 for Windows development.

## Technologies Used

- **.NET 8**: Latest version of .NET for building backend services and frontend applications.
- **MongoDB**: NoSQL database for storing application data.
- **Docker**: Containerization platform used to run the backend services.
- **.NET MAUI**: Framework for building cross-platform applications.
- **WinUI 3**: Windows UI Library for modern Windows app development.

## How It Works

- **Backend Services**: Each service is built using .NET 8 and runs as a Docker container. These services communicate with each other via HTTP and share a MongoDB instance for data storage.
- **Frontend Application**: Built with .NET MAUI, the frontend provides a modern, cross-platform user interface. It interacts with the backend services to authenticate users, store passwords, and manage user data.
- **MongoDB**: Stores all the application data, including user credentials and encrypted passwords.
- **Docker**: Containers are used to isolate services, making the application more secure and easier to deploy.

## Project Structure

```plaintext
Password-Management-CSharp/
├── backend/
│   ├── AuthenticationService/
│   ├── NotificationService/
│   ├── PasswordStorageService/
│   ├── UserManagementService/
├── frontend/
│   └── PasswordManagerApp/
├── infrastructure/
│   ├── Docker/
│   │   └── docker-compose.yml
│   └── Scripts/
├── .vscode/
│   ├── launch.json
│   └── tasks.json
├── LICENSE
├── Password-Management-CSharp.generated.sln
└── README.md
```

## Prerequisites

- Install **WinUI 3** from the Microsoft Store.
- Ensure **.NET 8 SDK** is installed.
- Docker should be installed and running.

## Getting Started

### Step 1: Launch Docker Services

1. Open Visual Studio Code.
2. Open the **Command Palette** (`Ctrl+Shift+P`).
3. Select **Run Task** and choose **Launch Docker Services**.

This task will build all the backend services and start Docker containers for each service. Make sure Docker Desktop is running.

### Step 2: Open WinUI 3 Application

Before running the frontend application, you must have the **WinUI 3 Application** open.

1. Install **WinUI 3** from the Microsoft Store.
2. Launch the **WinUI 3 Application** from your Start menu or Apps list.
3. Leave this application running in the background.

### Step 3: Launch .NET MAUI App

1. In Visual Studio Code, open the **Command Palette** (`Ctrl+Shift+P`).
2. Select **Run Task** and choose **Launch .NET MAUI App**.

This task will build and run the MAUI frontend application. Make sure the **WinUI 3 Application** is still running.

## Troubleshooting

### Docker Services

- If Docker containers fail to start, ensure Docker Desktop is running and the Docker Compose file is correctly configured.
- Run `docker ps` to check if all services are running. If a service is not running, check the logs for errors using `docker logs <container_id>`.

### WinUI 3 Application

- If the WinUI 3 application is not installed, you will not be able to run the frontend. Ensure it is installed and running.

### .NET MAUI App

- If the application fails to launch, ensure you have the correct version of the .NET SDK and WinUI 3 installed.
- Check for any missing dependencies or libraries in the console output.
- If you encounter the error `System.TypeInitializationException`, ensure WinUI 3 is running and the correct framework is targeted.