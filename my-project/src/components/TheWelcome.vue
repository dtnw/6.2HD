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
    Course Name:
    <a href="https://www.deakin.edu.au/course/master-cyber-security-international" target="_blank" rel="noopener">Master of Cyber Security</a>.
    <br>
    Course Code: S734
  </WelcomeItem>

  <WelcomeItem>
    <template #icon>
      <DocumentationIcon />
    </template>
    <template #heading>Unit Information</template>
    Unit Code: SIT753
    <br>
    Unit Name:
    <a href="https://www.deakin.edu.au/courses/unit?unit=SIT753" target="_blank" rel="noopener">Professional Practice in Information Technology</a>

    
  </WelcomeItem>
</template>
