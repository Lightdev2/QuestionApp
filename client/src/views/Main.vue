<template>
  <div>
    <div class="main__header">
      <q-title> Questions </q-title>
      <essential-button>
        <template #label> Ask a Question </template>
      </essential-button>
    </div>
    <div class="main__tabs">
      <tabs-component
        :tabs="tabs"
        :active-tab="activeTab"
        @apply:tab="handleTab"
      />
    </div>

    <div class="main__content">
      <question v-for="item in 10" :key="item"/>
    </div>
  </div>
</template>

<script>
import QTitle from "@/components/QTitle";
import TabsComponent from "@/components/Tabs";
import EssentialButton from "@/components/EssentialButton";
import Question from "@/components/Question";
export default {
  name: "Main",
  components: {
    QTitle,
    TabsComponent,
    EssentialButton,
    Question
  },
};
</script>

<script setup>
const tabs = ["Interesting", "Popular", "During the week", "During the month"];
import { ref } from "vue";

const activeTab = ref(tabs[1]);

const handleTab = (_tab) => {
  activeTab.value = _tab;
};
</script>

<style scoped lang="scss">
.main {
  &__header {
    display: flex;
    justify-content: space-between;
    margin-left: 10px;
  }
  &__tabs {
    display: flex;
    justify-content:flex-end;
    margin-top: 2rem;
  }
  &__content {
    margin-top: 1rem;
  }
}
</style>
