<script setup>
import WelcomeItem from './WelcomeItem.vue'
import DocumentationIcon from './icons/IconDocumentation.vue'
import SupportIcon from './icons/IconSupport.vue'
</script>

<template>
  <WelcomeItem>
    <template #icon>
      <SupportIcon />
    </template>
    <template #heading>Student Information</template>
    Name: Derby Teo Nyet Wen
    <br>
    Student ID: S221134621
    <br>
    Email: 
    <a href= "mailto: S221134621@deakin.edu.au"> S221134621@deakin.edu.au </a>
  </WelcomeItem>

  <WelcomeItem>
    <template #icon>
      <DocumentationIcon />
    </template>
    <template #heading>Unit Course Information</template>

    Course Name:
    <a href="https://www.deakin.edu.au/course/master-cyber-security-international" target="_blank" rel="noopener">Master of Cyber Security</a>.
    <br>
    Course Code: S734
    <br>
    Unit Code: 
    <a href="https://www.deakin.edu.au/courses/unit?unit=SIT753" target="_blank" rel="noopener">SIT753 Professional Practice in Information Technology</a>

    
  </WelcomeItem>
</template>
