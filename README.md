# WCF Remote Calculation Service (RPC-style Chat/Compute Client)

A client-server distributed application built with **Windows Communication Foundation (WCF)** — .NET's framework for building remote procedure call (RPC) style services, conceptually equivalent to Java RMI.

## What it does

- **`WCF_Library_Class`** — defines the service contract `IServiceChat` (a `[ServiceContract]` interface) and its implementation `ServiceChat`, which exposes a remote `TASK(a, b, c, x)` method that computes a Taylor-series-style summation server-side
- **`HOST`** — a console app that hosts the WCF service (`ServiceHost`), making `TASK()` callable remotely
- **`Client`** — a WPF desktop application that connects to the hosted service and invokes `TASK()` remotely, displaying the result in a window

## Tech stack

C# / .NET Framework, **WCF** (`System.ServiceModel`), WPF for the client UI.

## Running

1. Open the solution in Visual Studio, restore NuGet packages
2. Run `HOST` first — it starts the WCF service and waits for connections
3. Run `Client` — it connects to the running host and calls the remote method

## Why it matters

This demonstrates the core concept of **remote procedure calls / service-oriented architecture**: defining a contract, hosting an implementation as a separate process, and calling it transparently from a client as if it were a local method — the same pattern behind modern microservices and gRPC.
