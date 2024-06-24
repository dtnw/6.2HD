<script setup>
import AboutItem from './AboutItem.vue'
import ToolingIcon from './icons/IconTooling.vue'
import EcosystemIcon from './icons/IconEcosystem.vue'
import CommunityIcon from './icons/IconCommunity.vue'
</script>

<template>
  <AboutItem>
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
  </AboutItem>

  <AboutItem>
    <template #icon>
      <ToolingIcon />
    </template>
    
    <template #heading>Documentation</template>

    This website is created by
    <a href="https://vuejs.org/" target="_blank" rel="noopener">Vue.js</a>.

      </AboutItem>

  <AboutItem>
    <template #icon>
      <EcosystemIcon />
    </template>
    
    <template #heading>Support Vue</template>

    As an independent project, Vue relies on community backing for its sustainability. You can help
    us by
    <a href="https://vuejs.org/sponsor/" target="_blank" rel="noopener">becoming a sponsor</a>.
      </AboutItem>

  <AboutItem>
    <template #icon>
      <CommunityIcon />
    </template>
    <template #heading>Task 6.2 HD</template>
    DevOps Pipeline with Jenkins
    <br>
    Got stuck? Ask your question on
    <a href="https://chat.vuejs.org" target="_blank" rel="noopener">Vue Land</a>, our official
    Discord server, or
    <a href="https://stackoverflow.com/questions/tagged/vue.js" target="_blank" rel="noopener"
      >StackOverflow</a
    >. You should also subscribe to
    <a href="https://news.vuejs.org" target="_blank" rel="noopener">our mailing list</a> and follow
    the official
    <a href="https://twitter.com/vuejs" target="_blank" rel="noopener">@vuejs</a>
    twitter account for latest news in the Vue world.
  </AboutItem>

  <AboutItem>
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
    <a href="https://www.deakin.edu.au/courses/unit?unit=SIT753" target="_blank" rel="noopener">Professional Practice in Information Technology</a>

    
  </AboutItem>
</template>
