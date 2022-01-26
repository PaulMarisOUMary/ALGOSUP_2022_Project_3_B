<details>
<summary><strong id="table_of_contents">Table of Contents</strong></summary>

- [Project 3: Sound Synthesizer Group B](#project-3-sound-synthesizer-group-b)
- [Overview](#overview)
  - [1. Stakeholders](#1-stakeholders)
  - [2. Project target](#2-project-target)
  - [3. Project and scope](#3-project-and-scope)
  - [4. Risks and assumptions](#4-risks-and-assumptions)
  - [5. Use cases](#5-use-cases)
  - [6. Requirements specs](#6-requirements-specs)
  - [7. Solution overview](#7-solution-overview)
  - [8. System configurations](#8-system-configurations)
  - [9. Error reporting and exception handling](#10-error-reporting-and-exception-handling)

</details>

# Project 3: Sound Synthesizer Group B

Functionnal Specification **January 2022**
Team: *Paul MARIS, Laurent BOUQUIN, Florent HUREAUX, Arthur LEMOINE, Maxime PAGES, Pierre GORIN*

# Overview

The aim of this project is to create a sound synthesizer that can be used to create
programmable music. This project was inspired by Sonic Pi (https://sonic-pi.net/) and other live
coding music packages. The ultimate aim of this project is to be able to play music from code that looks something like the code given bellow.
```fsharp
let note length note octave =
  Creation.makeNote Creation.sine length note octave
  |> Envelope.apply 0.9 0.5 0.1 0.4
  |> Filter.flatten 0.4
  |> Filter.echo 0.4

let halfNote = note 0.5
let quaterNote = note 0.25
let eightNote = note 0.125

let tune = seq { 
  yield! quaterNote Note.B 4
  yield! quaterNote Note.B 4
  yield! eightNote Note.B 4
  yield! eightNote Note.B 4
  yield! eightNote Note.C 4
  yield! eightNote Note.D 4
  yield! halfNote Note.D 4
  yield! quaterNote Note.D 4
  yield! eightNote Note.D 4
  yield! eightNote Note.C 4
  yield! eightNote Note.C 4
  yield! eightNote Note.B 4 
} |> Filter.applyFunction (Fliter.lfo 0.6)

// play the tune
let player = Player.Play(tune, Repeat = true)
```
More details about the project can be found in the [F# Project - Sound Synthesis.pdf](https://github.com/PaulMarisOUMary/ALGOSUP_2022_Project_3_B/blob/main/Documentation/F%23%20Project%20-%20Sound%20Synthesis.pdf) document.

## 1. Stakeholders
| Team            | Roles |
| --------------- | ----- |
| Paul MARIS      |       |
| Laurent BOUQUIN |       |
| Florent HUREAUX |       |
| Arthur LEMOINE  |       |
| Maxime PAGES    |       |
| Pierre GORIN    |       |

## 2. Project target
Anyone interested in creating sounds in a programmable way or incorporate in a program should be able easily to use this project. 

## 3. Project and scope
  - Function to generate four basic Waveforms:
    - Sine Wave
    - Square Wave
    - Sawtooth Wave
    - Triangle Wave
  - Function to save waveform to disk
  - Function to read a section of an audio file
  - Function to play the waveform directly
  - Basic Filters:
    - Overdriven filter
    - Echo filter
    - Flange filter
    - Reverb filter
  - Spectroscope
  - Low frequency oscillator
  - MP3 Compression
  
  
## 4. Risks and assumptions
- Team absenteeism/unavailable → understaffing.

## 5. Use cases
- Recurring steps :
  - User creates a new sound
  - User adds new wave(s) to the sound
  - User adds a new envelope to the sound
  - User adds new filter(s) to the sound
- Then, user can:
- Use case 1:
  - User saves the sound file
- Use case 2:
  - User plays the sound
- Use case 3:
  - User plays the sound in a loop
- Use case 4:
  - User display the sound in a spectroscope

## 6. Requirements specs

The entirety of our work is program in F#.
To run our project, we use .net 6.0 with the help of the IDE Visual Studio Community.
In term of library, we use : 
  - SFML (used to play/modify everything related to the sound)
  - Xplot (used to display our sound wave)
We also use GitHub as hosting platform for version control and collaboration. Thanks to this, we can work together on projects from anywhere. To split work with all the team member, we use the project section of Github.

## 7. Solution overview

This project is available for everyone (no matter your knowledge in physics, music or coding).
The user will have a graphical interface where he can play the sound he want, record it , and dowload it directly on his computer

## 8. System configurations

This project work essentialy on Windows.
Some of the functionnality doesn't work on mac (like playing directly from Visual Studio) but we can still download the wav file and play it from another source (for example, using the terminal)

## 9. Error reporting and exception handling

All the project is run with Unit Test (Nunit) to assure that every function is working properly no matter the change we've done.
We also using Github action.
